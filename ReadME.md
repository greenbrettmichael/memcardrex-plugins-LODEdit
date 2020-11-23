# Legend of Dragoon Save Editor
Save editor plugin for memcardrex to tweak saved Legend of Dragoon data. This project was created to inspect and modify corrupted Legend of Dragoon saves and the default interface will be advanced and allow invalid configurations.

## Install instructions
1. install memcardrex
2. download LODEdit.dll and copy into the memcardrex/plugin directory
To use, right click to open the context menu on opened save in memcardrex and select "Edit with Plugin->LODEdit". Your changes will be completed once OK is selected from within the plugin and the memory file has been saved in memcardrex.

## FAQ
### I changed x and do not see the change?
If you are using memcardrex to change an emulator save, the emulator should not be running during the save editing. Emulators often load memory files into RAM, and will overwrite your changes. Gold is the simplest and most visual change if you would like to experiment with live changes. 

## TODO
1. Armor
2. Items
3. Warps
4. Treasure
5. Stardust
6. Menu Options (settings, set addition, party replace menu, battle count)
7. Debug
8. Story Events
9. Statuses
10. Create "Basic" menu with shortcuts to high demand changes
