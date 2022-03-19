# Legend of Dragoon Save Editor
Save editor plugin for memcardrex to tweak saved Legend of Dragoon data. This project was created to inspect and modify corrupted Legend of Dragoon saves and the default interface will be advanced and allow invalid configurations.

## Install instructions
1. install memcardrex
2. download LODEdit.dll and copy into the memcardrex/plugin directory
To use, right click to open the context menu on opened save in memcardrex and select "Edit with Plugin->LODEdit". Your changes will be completed once OK is selected from within the plugin and the memory file has been saved in memcardrex.

## Features
1. Gold
2. Time Played
3. Dragoon Spirits
4. Items
5. Goods (Key Items)
6. Armor
7. Stardust
8. Character Levels
9. Character HP/MP/SP
10. Character Equipment
11. Character Additions

### TODO
1. Warps (save locations)
2. Treasure
3. Menu Options (settings, set addition, party replace menu, battle count)
4. Debug
5. Story Events
6. Statuses
7. Create "Basic" menu with shortcuts to high demand changes
8. Integration with the popular Dramod tool

## FAQ
### I changed x and do not see the change?
If you are using memcardrex to change an emulator save, the emulator should not be running during the save editing. Emulators often load memory files into RAM, and will overwrite your changes. Gold is the simplest and most visual change if you would like to experiment with live changes. 

### Which versions of the game does this work with?
This plugin was designed with the NTSC(US) version in mind. There is experimental support for PAL(International non-japan) copies that has not been added to main releases. There is likely is some difference with Japanese version saves as that version supports a seperate Dabas game.

## Contributing
This is a C# project that acts as a plugin for memcardrex. LODEdit.sln is a VS2022 solution that targets .NET Framework 2.0 (you may have to dowload this. The interface with memcardrex can be found in LODEdit/Plugin.cs. Since this is a plugin, debugging is not straight-forward. You must deploy a debug dll to the memcardrex/plugins folder, then attach the debugger to a running memcardrex process. I do not have much experience with the C# language so the architecture is fairly poor and there are not currently any tests.

The current developer notes can be found in the LODEdit/Additional folder. These record the current state of knowledge about the save format. For current intended improvements there are Github issues. Please reach out via the respective Github issue or discord for any assistance. There is no required issue or PR structure for submissions.



