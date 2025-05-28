# WWHD Hacker
*The official hacker for TCPGecko on Aroma*

* [Installation](#installation)
* [Using the hacker](#using-the-hacker)
  * [Main features](#main-features)
  * [Misc features](#misc-features)
  * [Data viewer](#data-viewer)
  * [Advanced](#advanced)
  * [Items manager](#items-manager)
  * [Memfiles manager](#memfiles-manager)
  * [Teleporter](#teleporter)
* [About](#about)
  * [Suggestions / Bug report](#suggestions--bug-report)
  * [Credits](#credits)


## Installation
**If your Wii U does not have the Aroma CFW yet, you should install it first. [This guide](https://wiiu.hacks.guide/aroma/getting-started.html) will help you get started**

You will need to have the TCPGecko plugin installed on your Wii U. Releases can be found [here](https://github.com/Teotia444/TCPGeckoAroma/releases/latest). To install it, simply put the `TCPGecko.wps` file into `sd:/wiiu/environments/aroma/plugins`. Note that if you need to update this hacker at some point, you might need to update the plugin too. If it is the case, it will be written on the release infos.

You should also have the [ftpiiu](https://github.com/wiiu-env/ftpiiu_plugin/releases/latest) plugin installed if its not the case already. Make sure to check the **Allow access to system files** option in the ftpiiu config menu to fully utilize this hacker. You can access the config menu by pressing the following combo : `L + Dpad Down + Minus`.

Make sure to grab your Wii U's local IP address from ftpiiu's config menu. It will look like this : `192.168.XXX.XXX`.

## Using the hacker
**For speedrunners of WWHD : Make sure the plugin is completly disabled before starting a run! You can disable it by pressing X on the config menu.**

*First off, enter your Wii U's IP address and once you are in game, hit Connect.*

### Main features
This tab contains most of the features from the old hacker. It contains basic cheats that can be accessed by clicking the buttons.

### Misc features
Macros: You can assign buttons to do a specific action like levitate or give storage. You can also check the "Masterkey" checkbox to have them require pressing the masterkey button and their respective button. 

Animation sets: The game uses two different animation sets to load cutscenes from early in the game and from late in the game. If you need to watch an end game cutscene, switching to animation set 2 may prevent some crash. *Note: the animation set is switch to anim set 2 when watching the cutscene before the Helmaroc fight in the vanilla game.*

Frame Advance: Allows to completly pause the game and to advance it frame by frame.

### Data viewer
Allows to see a bunch of information on Link's current state. You can also detach it into another window to keep using the hacker while having it on the side.

### Advanced
Mostly for people who wants to search for ram stuff. Right now there is a half working memory viewer and a peeker/poker. Useless if you are not interested in nerd stuff

### Items manager
Allows to manage your items. You can also check the `auto-update` checkbox to track your items in game. *Note : if you are not using it actively, leave the auto-update check off because it will make TCPGecko lag a bit.*

There are also cheats to give capacities beyond their max size. They might appear glitched or incorrect on the UI but they are in fact working.

### Memfiles manager
Memfiles : Allows to store part of the game's ram and restore it at any point. You can think of them as cardboard savestates. Right now, the following is saved:
- Health
- Magic
- Ammos (bombs/arrows/rupees)
- Current stage
- Position and angle
- Every flag array
- Inventory

They can be useful to practice a dungeon for example, so that you can restore flags and items to the state right before completing the dungeon and keep on training.

Savefiles : You can also transfer save files from your computer to your Wii U. This requires having properly set up ftpiiu prior to this. 

For dumping save data, you can stay on the game and hit the button after having saved the game. For loading save data, you first want to exit to the home menu and then hit the button. Note that this injection is temporary and you have to save the game manually to get it to be persistent

### Teleporter
Allows you to teleport with a more user friendly interface than just typing the stage etc.

Left clicking on an island will teleport you automatically to said island, while right clicking will open a subset of that island with related stuff like caves or dungeons. You can also right click one of these subsets to mark them as favorites.

## About


### Suggestions / Bug report
If you have any suggestions, feel free to DM me on discord (user is `teotia444`) or join the [WWHD Speedrunning server](https://discord.gg/VCEym4jYUX) to ping me (The latter would be more appreciated, so that other people can also help you diagnose/see your suggestions). 

Of course, I will also be on the lookout for both issues opened on this github page and [the plugin's github](https://github.com/Teotia444/TCPGeckoAroma/releases/latest).

### Credits
Credits goes to [the WUT project](https://github.com/wiiu-env/) for making a great job on their plugin backend system which makes this whole project possible in the first place. 

Credits to the WWHD community who was a huge help in getting this project going, especially for Jake with his [open source DoomZoom tool](https://github.com/JakeButf/DoomZoom/), and Indx who maintained old tools which got me motivated and inspired for this project. 

Credits to the Decomp project which helped in getting this project going too, and for Soup who offered his help on the Ghidra stuff. 

Last but not least, credits to the many testers (and friends!) of this tool who reported early bugs and made most of the features a reality through their suggestions.