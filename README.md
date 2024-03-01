# CefGlue

This is not the official CefGlue repository; it is located at:  
https://gitlab.com/xiliumhq/chromiumembedded/cefglue

I use this project for my own projects.

---

# Personal notes about CEF and .NET

Following are the results of my research about CEF and .NET.

# CEF
Official repository:  
https://bitbucket.org/chromiumembedded/cef/src/master/

Builds:  
https://cef-builds.spotifycdn.com/index.html

# CefGlue

It is a .NET project that uses P/Invokes directly to CEF.  

I prefer CefGlue because it is truly cross-platform, working on Linux, Mac, and Windows.

It lacks information on how to use it on Mac;
 I had to read the CEF project source code to understand it, but in the end, it worked.

Relevant info [here](https://stackoverflow.com/questions/12224798/any-reason-to-prefer-cefsharp-over-cefglue-or-vice-versa).

## How to update CefGlue to a more recent version of CEF?

CefGlue has scripts to generate and update the bindings to the CEF libs.

The folder `\CefGlue.Interop.Gen` contains the scripts to generate the bindings; 
 you must have Python installed on your computer.

Replace the folder: `include` inside `\CefGlue.Interop.Gen` with the version you want;
 it is available at https://cef-builds.spotifycdn.com/index.html or (I didn't check) at their repository.

There is a cmd file that helps, but the command is:
```bash
python -B cefglue_interop_gen.py --cpp-header-dir include --cefglue-dir ..\CefGlue\ --no-backup
```

After running the code generator, you must run `normalize-line-endings.cmd` to fix line endings (useful for Git).

Finally, in the folder `\CefGlue.Interop.Gen`, a lot of temp files are generated. I didn't understand enough yet, but these files can be deleted.

# Other projects

## An interesting CefGlue fork
They are active and have a working example with Avalonia.  
https://github.com/OutSystems/CefGlue

## Chromely

They use CefGlue internally and have some documentation.

## CefNet

CefNet is a different project; it doesn't share the same code as CefGlue or CefSharp.

I was able to run a browser using Avalonia on Mac using this project; I think this project is promising.  
https://github.com/CefNet/CefNet


Feel free to adjust according to your preferences!