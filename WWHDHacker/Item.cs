using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace WWHDHacker
{
    public enum ItemEnum
    {
        Telescope,
        Sail,
        WindWaker,
        GrapplingHook,
        SpoilsBag,
        Boomerang,
        Leaf,
        Sword,
        TingleBottle,
        Pictobox,
        IronBoots,
        MagicArmor,
        BaitBag,
        Bow,
        Bombs,
        Shield,
        CabanaDeed,
        MaggiesLetter,
        MoblinsLetter,
        NoteToMom,
        DeliveryBag,
        Hookshot,
        Hammer,
        PowerBracelets,
        Bottle,
        WindsRequiem,
        BalladOfGales,
        CommandMelody,
        EarthGodLyric,
        WindGodAria,
        SongOfPassing,
        HeroCharm,
        DinsPearl,
        NayrusPearl,
        FaroresPearl,
        Triforce,
        BombBag,
        Quiver,
        Wallet,
        MagicMeter,
        NotSlot
    }

    public struct Item
    {
        public Slot slot;
        public string name;
        public int value;
        public ItemEnum @enum;

        private Item(Slot _slot, int _value, string _name, ItemEnum _enum)
        {
            slot = _slot;
            value = _value;
            name = _name;
            @enum = _enum;
        }

        public static List<Item> GetAll()
        {
            List<Item> all = new List<Item>();
            foreach (FieldInfo fi in typeof(Items).GetFields(BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic)){
                all.Add((Item)fi.GetValue(null));
            }
            return all;
        }

        public static Item Instance(Slot _slot, int _value, string _name, ItemEnum _enum, bool addToList=true)
        {
            var i = new Item(_slot, _value, _name, _enum);
            return i;
        }

    }

    public struct Slot
    {
        public int address;
        private Slot(int _address)
        {
            address = _address;
        }
        public static List<Slot> GetAll()
        {
            List<Slot> all = new List<Slot>();
            foreach (FieldInfo fi in typeof(Slots).GetFields(BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic))
            {
                all.Add((Slot)fi.GetValue(null));
            }
            return all;
        }

        public static Slot Instance(int _address)
        {
            Slot s = new Slot(_address);
            return s;
        }

    }

    public class Slots
    {
        
        public static Slot telescope_slot = Slot.Instance(0x1506b53c);
        public static Slot tingle_bottle_slot = Slot.Instance(0x1506b543);
        public static Slot pictobox_slot = Slot.Instance(0x1506b544);
        public static Slot spoils_bag_slot = Slot.Instance(0x1506b540);
        public static Slot bait_bag_slot = Slot.Instance(0x1506b547);
        public static Slot delivery_bag_slot = Slot.Instance(0x1506b54e);
        public static Slot grappling_hook_slot = Slot.Instance(0x1506b53f);
        public static Slot boomerang_slot = Slot.Instance(0x1506b541);
        public static Slot skull_hammer_slot = Slot.Instance(0x1506b550);
        public static Slot deku_leaf_slot = Slot.Instance(0x1506b542);
        public static Slot bow_slot = Slot.Instance(0x1506b548);
        public static Slot iron_boots_slot = Slot.Instance(0x1506b545);
        public static Slot bombs_slot = Slot.Instance(0x1506b549);
        public static Slot hookshot_slot = Slot.Instance(0x1506b54f);
        public static Slot magic_armor_slot = Slot.Instance(0x1506b546);
        public static Slot bottle1_slot = Slot.Instance(0x1506b54a);
        public static Slot bottle2_slot = Slot.Instance(0x1506b54b);
        public static Slot bottle3_slot = Slot.Instance(0x1506b54c);
        public static Slot bottle4_slot = Slot.Instance(0x1506b54d);


        public static Slot sword_slot = Slot.Instance(0x1506b50e);
        public static Slot shield_slot = Slot.Instance(0x1506b50f);
        public static Slot wind_waker_slot = Slot.Instance(0x1506b53e);
        public static Slot hero_charm_slot = Slot.Instance(0x1506b5b8);
        public static Slot sail_slot = Slot.Instance(0x1506b53d);
        public static Slot power_bracelets_slot = Slot.Instance(0x1506b5b6);

        public static Slot triforce_slot = Slot.Instance(0x1506b5be);
        public static Slot pearls_slot = Slot.Instance(0x1506b5bf);

        public static Slot songs_slot = Slot.Instance(0x1506b5bd);


        public static Slot bomb_bag_slot = Slot.Instance(0x1506b570);
        public static Slot quiver_slot = Slot.Instance(0x1506b56f);
        public static Slot wallet_slot = Slot.Instance(0x00);
        public static Slot magic_meter_slot = Slot.Instance(0x1506b513);

        public static Slot mail_bag_1_slot = Slot.Instance(0x1506b586);
        public static Slot mail_bag_2_slot = Slot.Instance(0x1506b587);
        public static Slot mail_bag_3_slot = Slot.Instance(0x1506b588);
        public static Slot mail_bag_4_slot = Slot.Instance(0x1506b589);
        public static Slot mail_bag_5_slot = Slot.Instance(0x1506b58a);
        public static Slot mail_bag_6_slot = Slot.Instance(0x1506b58b);
        public static Slot mail_bag_7_slot = Slot.Instance(0x1506b58c);
        public static Slot mail_bag_8_slot = Slot.Instance(0x1506b58d);

        public static Slot skull_neclace_slot = Slot.Instance(0x1506b59c);
        public static Slot boko_seed_slot = Slot.Instance(0x1506b59d);
        public static Slot golden_feathers_slot = Slot.Instance(0x1506b59e);
        public static Slot knight_crest_slot = Slot.Instance(0x1506b59f);
        public static Slot red_jelly_slot = Slot.Instance(0x1506b5a0);
        public static Slot green_jelly_slot = Slot.Instance(0x1506b5a1);
        public static Slot blue_jelly_slot = Slot.Instance(0x1506b5a2);
        public static Slot joy_pendant_slot = Slot.Instance(0x1506b5a3);
    }

    public class Items
    {
        public static Item telescope = Item.Instance(Slots.telescope_slot, 0x20, "Telescope", ItemEnum.Telescope);
        public static Item tingle_bottle = Item.Instance(Slots.tingle_bottle_slot, 0x21, "TingleBottle", ItemEnum.TingleBottle);
        public static Item pictobox = Item.Instance(Slots.pictobox_slot, 0x23, "PictoBox", ItemEnum.Pictobox);
        public static Item deluxe_pictobox = Item.Instance(Slots.pictobox_slot, 0x26, "PictoBoxDeluxe", ItemEnum.Pictobox);
        public static Item spoils_bag = Item.Instance(Slots.spoils_bag_slot, 0x24, "SpoilsBag", ItemEnum.SpoilsBag);
        public static Item bait_bag = Item.Instance(Slots.bait_bag_slot, 0x2c, "BaitBag", ItemEnum.BaitBag);
        public static Item delivery_bag = Item.Instance(Slots.delivery_bag_slot, 0x30, "DeliveryBag", ItemEnum.DeliveryBag);
        public static Item grappling_hook = Item.Instance(Slots.grappling_hook_slot, 0x25, "GrapplingHook", ItemEnum.GrapplingHook);
        public static Item boomerang = Item.Instance(Slots.boomerang_slot, 0x2d, "Boomerang", ItemEnum.Boomerang);
        public static Item skull_hammer = Item.Instance(Slots.skull_hammer_slot, 0x33, "SkullHammer", ItemEnum.Hammer);
        public static Item deku_leaf = Item.Instance(Slots.deku_leaf_slot, 0x34, "DekuLeaf", ItemEnum.Leaf);
        public static Item bow = Item.Instance(Slots.bow_slot, 0x27, "Bow", ItemEnum.Bow);
        public static Item elemental_bow = Item.Instance(Slots.bow_slot, 0x35, "BowFireIce", ItemEnum.Bow);
        public static Item magical_bow = Item.Instance(Slots.bow_slot, 0x36, "BowLight", ItemEnum.Bow);
        public static Item iron_boots = Item.Instance(Slots.iron_boots_slot, 0x29, "IronBoots", ItemEnum.IronBoots);
        public static Item bombs = Item.Instance(Slots.bombs_slot, 0x31, "Bombs", ItemEnum.Bombs);
        public static Item hookshot = Item.Instance(Slots.hookshot_slot, 0x2f, "Hookshot", ItemEnum.Hookshot);
        public static Item magic_armor = Item.Instance(Slots.magic_armor_slot, 0x2a, "MagicArmor", ItemEnum.MagicArmor);
        public static Item bottle = Item.Instance(Slots.bottle1_slot, 0x50, "Bottle", ItemEnum.Bottle);


        public static Item hero_sword = Item.Instance(Slots.sword_slot, 0x38, "SwordHero", ItemEnum.Sword);
        public static Item master_sword = Item.Instance(Slots.sword_slot, 0x39, "SwordMasterUnpowered", ItemEnum.Sword);
        public static Item master_sword_t1 = Item.Instance(Slots.sword_slot, 0x3a, "SwordMasterHalfPowered", ItemEnum.Sword);
        public static Item master_sword_t2 = Item.Instance(Slots.sword_slot, 0x3e, "SwordMasterFullPowered", ItemEnum.Sword);

        public static Item hero_shield = Item.Instance(Slots.shield_slot, 0x3b, "Shield", ItemEnum.Shield);
        public static Item mirror_shield = Item.Instance(Slots.shield_slot, 0x3c, "ShieldMirror", ItemEnum.Shield);

        public static Item normal_sail = Item.Instance(Slots.sail_slot, 0x78, "Sail", ItemEnum.Sail);
        public static Item swift_sail = Item.Instance(Slots.sail_slot, 0x77, "SailSwift", ItemEnum.Sail);

        public static Item wind_waker = Item.Instance(Slots.wind_waker_slot, 0x22, "WindWaker", ItemEnum.WindWaker);
        public static Item hero_charm = Item.Instance(Slots.hero_charm_slot, 0x01, "HerosCharm", ItemEnum.HeroCharm);
        public static Item power_bracelets = Item.Instance(Slots.power_bracelets_slot, 0xff, "PowerBracelets", ItemEnum.PowerBracelets);

        public static Item triforce = Item.Instance(Slots.triforce_slot, 0xff, "Triforce", ItemEnum.Triforce);
        public static Item nayrus_pearls = Item.Instance(Slots.pearls_slot, 0b00000001, "PearlNayrus", ItemEnum.NayrusPearl);
        public static Item dins_pearls = Item.Instance(Slots.pearls_slot, 0b00000010, "PearlDins", ItemEnum.DinsPearl);
        public static Item faores_pearls = Item.Instance(Slots.pearls_slot, 0b00000100, "PearlFarores", ItemEnum.FaroresPearl);

        public static Item wind_requiem = Item.Instance(Slots.songs_slot, 0b00000001, "WindsRequiem", ItemEnum.WindsRequiem);
        public static Item ballad_of_gales = Item.Instance(Slots.songs_slot, 0b00000010, "BalladOfGales", ItemEnum.BalladOfGales);
        public static Item command_melody = Item.Instance(Slots.songs_slot, 0b00000100, "CommandMelody", ItemEnum.CommandMelody);
        public static Item earth_god_lyric = Item.Instance(Slots.songs_slot, 0b00001000, "EarthGodsLyric", ItemEnum.EarthGodLyric);
        public static Item wind_god_aria = Item.Instance(Slots.songs_slot, 0b00010000, "WindGodsAria", ItemEnum.WindGodAria);
        public static Item song_of_passing = Item.Instance(Slots.songs_slot, 0b00100000, "SongOfPassing", ItemEnum.SongOfPassing);

        public static Item bomb_bag = Item.Instance(Slots.bomb_bag_slot, 60, "BiggerBombBag", ItemEnum.BombBag);
        public static Item bomb_bag_big = Item.Instance(Slots.bomb_bag_slot, 99, "BiggestBombBag", ItemEnum.BombBag);
        public static Item quiver = Item.Instance(Slots.quiver_slot, 60, "BiggerQuiver", ItemEnum.Quiver);
        public static Item quiver_big = Item.Instance(Slots.quiver_slot, 99, "BiggestQuiver", ItemEnum.Quiver);
        public static Item wallet = Item.Instance(Slots.wallet_slot, 1000, "BiggerWallet", ItemEnum.Wallet);
        public static Item wallet_big = Item.Instance(Slots.wallet_slot, 5000, "BiggestWallet", ItemEnum.Wallet);
        public static Item magic_meter_half = Item.Instance(Slots.magic_meter_slot, 16, "MagicBottle", ItemEnum.MagicMeter);
        public static Item magic_meter_full = Item.Instance(Slots.magic_meter_slot, 32, "MagicDoubleBottle", ItemEnum.MagicMeter);



        public static Item town_flower = Item.Instance(Slots.mail_bag_1_slot, 0x8c, "(Delivery Item) Town Flower", ItemEnum.NotSlot);
        public static Item sea_flower = Item.Instance(Slots.mail_bag_1_slot, 0x8d, "(Delivery Item) Sea Flower",ItemEnum.NotSlot);
        public static Item exotic_flower = Item.Instance(Slots.mail_bag_1_slot, 0x8e, "(Delivery Item) Exotic Flower", ItemEnum.NotSlot);
        public static Item heros_flag = Item.Instance(Slots.mail_bag_1_slot, 0x8f, "(Delivery Item) Hero's flag", ItemEnum.NotSlot);
        public static Item big_catch_flag = Item.Instance(Slots.mail_bag_1_slot, 0x90, "(Delivery Item) Big Catch Flag", ItemEnum.NotSlot);
        public static Item big_sale_flag = Item.Instance(Slots.mail_bag_1_slot, 0x91, "(Delivery Item) Big Sale Flag", ItemEnum.NotSlot);
        public static Item pinwheel = Item.Instance(Slots.mail_bag_1_slot, 0x92, "(Delivery Item) Pinwheel", ItemEnum.NotSlot);
        public static Item sickle_moon_flag = Item.Instance(Slots.mail_bag_1_slot, 0x93, "(Delivery Item) Sickle Moon Flag", ItemEnum.NotSlot);
        public static Item skull_tower_idol = Item.Instance(Slots.mail_bag_1_slot, 0x94, "(Delivery Item) Skull Tower Flag", ItemEnum.NotSlot);
        public static Item fountain_idol = Item.Instance(Slots.mail_bag_1_slot, 0x95, "(Delivery Item) Fountain Idol", ItemEnum.NotSlot);
        public static Item postman_statue = Item.Instance(Slots.mail_bag_1_slot, 0x96, "(Delivery Item) Postman Statue", ItemEnum.NotSlot);
        public static Item shop_guru_statue = Item.Instance(Slots.mail_bag_1_slot, 0x97, "(Delivery Item) Shop Guru Statue", ItemEnum.NotSlot);
        public static Item father_letter = Item.Instance(Slots.mail_bag_1_slot, 0x98, "(Delivery Item) Father's Letter", ItemEnum.NotSlot);
        public static Item note_to_mom = Item.Instance(Slots.mail_bag_1_slot, 0x99, "NoteToMom", ItemEnum.NoteToMom);
        public static Item maggie_letter = Item.Instance(Slots.mail_bag_1_slot, 0x9a, "MaggiesLetter", ItemEnum.MaggiesLetter);
        public static Item moblin_letter = Item.Instance(Slots.mail_bag_1_slot, 0x9b, "MoblinsLetter", ItemEnum.MoblinsLetter);
        public static Item cabana_deed = Item.Instance(Slots.mail_bag_1_slot, 0x9c, "CabanaDeed", ItemEnum.CabanaDeed);
        public static Item complimentary_id = Item.Instance(Slots.mail_bag_1_slot, 0x9d, "(Delivery Item) Complimentary Id", ItemEnum.NotSlot);
        public static Item fill_up_coupon = Item.Instance(Slots.mail_bag_1_slot, 0x9e, "(Delivery Item) Fill Up Coupon", ItemEnum.NotSlot);



        /*public static Item skull_neclace = Item.Instance(Slots.skull_neclace_slot, 0x00);
        public static Item boko_seed = Item.Instance(Slots.boko_seed_slot, 0x00);
        public static Item golden_feathers = Item.Instance(Slots.golden_feathers_slot, 0x00);
        public static Item knight_crest = Item.Instance(Slots.knight_crest_slot, 0x00);
        public static Item red_jelly = Item.Instance(Slots.red_jelly_slot, 0x00);
        public static Item green_jelly = Item.Instance(Slots.green_jelly_slot, 0x00);
        public static Item blue_jelly = Item.Instance(Slots.blue_jelly_slot, 0x00);
        public static Item joy_pendant = Item.Instance(Slots.joy_pendant_slot, 0x00);*/

    }

    public class Equips
    {

        public static Slot x = Slot.Instance(0x10976e6b);
        public static Slot y = Slot.Instance(0x10976e6c);
        public static Slot r = Slot.Instance(0x10976e6d);
        
    }
}
