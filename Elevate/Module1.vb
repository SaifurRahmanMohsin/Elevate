Module Module1
    Sub Main()

        Dim s() As String = System.Environment.GetCommandLineArgs()
        If System.Environment.GetCommandLineArgs().Count = 2 Then
            Dim proc As New ProcessStartInfo
            proc.UseShellExecute = True
            proc.WorkingDirectory = Environment.CurrentDirectory
            proc.FileName = s(1)
            proc.Verb = "runas"

            Try
                Process.Start(proc)
            Catch
                ' The user refused to allow privileges elevation.
                ' Do nothing and return directly ...
                Return
            End Try
        Else
            MsgBox("Usage: " + s(0) + " <your-executable.exe>" + vbNewLine + vbNewLine + "Created by TheTimeTraveller (http:\\imoz.in)")
        End If
    End Sub
End Module
