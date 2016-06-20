[General]
SyntaxVersion=2
BeginHotkey=121
BeginHotkeyMod=0
PauseHotkey=0
PauseHotkeyMod=0
StopHotkey=123
StopHotkeyMod=0
RunOnce=1
EnableWindow=
MacroID=6c3ff39b-c81b-4e50-99fa-c516cdf23e8f
Description=ÎÒµÄ½Å±¾1
Enable=1
AutoRun=0
[Repeat]
Type=0
Number=1
[SetupUI]
Type=2
QUI=
[Relative]
SetupOCXFile=
[Comment]

[Script]
For 999
    KeyDown 17, 1
    KeyPress 75, 1
    KeyUp 17, 1
    Delay 60
    LeftClick 1
    KeyDown 17, 1
    KeyPress 86, 1
    Delay 50
    KeyUp 17, 1
    KeyDown 18, 1
    KeyPress 67, 1
    KeyUp 18, 1
    Delay 5000
Next
