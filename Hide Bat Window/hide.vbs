Set oShell = CreateObject ("Wscript.Shell") 
Dim strArgs
  strArgs = "cmd /c test.bat" //<--Put the name here
oShell.Run strArgs, 0, false
