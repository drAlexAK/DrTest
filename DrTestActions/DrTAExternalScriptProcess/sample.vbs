dim ta

if (WScript.Arguments.Count < 1) Then
 Call Msgbox ("You should specifiy path to shared xml file")
 WScript.Quit 1
End If

set ta = CreateObject("DrTest.TAComProvider")

if (WScript.Arguments.Count > 1) Then
    reason = WScript.Arguments.Item(1)
else
    reason = ""
end if

call ta.SetStatus(2, reason) rem the reason is optional parameter
rem call ta.SetStatus(4)
call ta.Save(WScript.Arguments.Item(0))

WScript.Quit 0
