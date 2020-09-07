# Stardust-password-solver
This program can solve the checksum characters of save-game passwords in the Stardust series of games. Interface done in Windows Forms. Horribly coded, but works for the most part. VS 2017 solution file included.

Works for the following games:
* Stardust (Amiga, 1993)
* Stardust (Atari ST, 1995)
* Super Stardust (Amiga AGA, 1994)
* Super Stardust (Amiga CD32, 1995)
* Super Stardust '96 (MS-DOS, 1996)

Each game uses a slightly different checksum calculation method, but they have similarities. Help of emulators and their debuggers was used to figure out the checksum calculation (emulators used: WinUAE, Hatari, DOSBox).


## Usage:

1. Select game by ticking the box next to it.

2. Enter the first 9 or 10 characters of the password, either by typing or by entering values for world, lives, weapon levels etc.

3. Full password appears at the top. Have fun!


## Notes:

* In the original Stardust games, world values of 6 or higher work differently. When a game is started with a password having world value of 6+, game progress continues from the last game, with the last attempted level marked as completed. Entering such a password right after booting up the game softlocks it in a buggy intermission screen.

* In the original Stardust games, the 9th character in the password isn't used for anything other than calculating the checksum, as far as I know.

* Weapons can be "overloaded" with custom passwords, by entering higher values than those normally possible during gameplay. The widely known "INTRODUCTION" password for Stardust game has a level 4/3 threeway weapon, for example. Too high values in certain weapon slots will crash the game instantly or soon after firing, though.

* Weapon levels for Super Stardust '96 may be off in some ways. I did the least testing on that game and haven't completely solved how it works. Checksum calculation part of it works though.

