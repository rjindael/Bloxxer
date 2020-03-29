# Bloxxer

Roblox helper

![Bloxxer v1.1.0 Dark mode](https://github.com/zi-blip/Bloxxer/raw/master/BloxxerShowcaseDark.png)
<br>
![Bloxxer v1.1.0 Light mode](https://github.com/zi-blip/Bloxxer/raw/master/BloxxerShowcaseLight.png)

# Adding scripts to the Script Hub
You can also add scripts to YOUR Bloxxer Script Hub! The process of adding scripts is very easy.

To add scripts, you need to make a folder in the `scripts` folder where Bloxxer is stored. Usually, Bloxxer is installed in a folder named `current` which is in the same directory as your Bloxxer_Bootstrapper.exe .
The folder will contain all the files needed for your script to work with Bloxxer. You can name the folder whatever you want.

Then, in that folder you should add these items (items with an asterisk [\*] are necessary items for the script to function):
 * \*`info.json`  - The info for Bloxxer to display. More on `info.json` later.
 * \*`script.lua` - The script that Bloxxer will actually execute.
 * `image.png`    - A thumbnail of the script (such as it's GUI, what it does to players, etc.) If there is no image.png, it will show "No Image." The thumbnail should be 338 pixels by 192 pixels to fit properly.

`info.json` is very simple to understand. It's just a JSON file with 4 items:
* `name`        - The human-readable name of the script.
* `description` - A description of the script. Links will be clickable, and adding `\n` will create a newline.
* `author`      - The author or authors of the script.
* `version`     - The current version of the script. It would be appreciated to use [SemVer](https://semver.org/) in order to be consistent with other scripts, but you can use whatever versioning system you please.

Put all the files you have created in your new script folder, and put the script folder in the `scripts` folder as mentioned previously. Then, upon opening Bloxxer, you can execute your script via the Script Hub! Zip up your script and share it with others! Do whatever you want!

You can view the other scripts in the `scripts` folder for inspiration / help. I have included 2 that I have made myself, and 2 other very popular scripts used across the Roblox **helping** community.
