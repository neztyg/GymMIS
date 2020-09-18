Module modConnection
    Public connDB As New SqlClient.SqlConnection
    Public comDB As New SqlClient.SqlCommand
    Public rdDB As SqlClient.SqlDataReader

    'Public Function IPv4Address() As String
    '    IPv4Address = String.Empty
    '    Dim strHostName As String = System.Net.Dns.GetHostName()
    '    Dim iphe As System.Net.IPHostEntry = System.Net.Dns.GetHostEntry(strHostName)

    '    For Each ipheal As System.Net.IPAddress In iphe.AddressList
    '        If ipheal.AddressFamily = System.Net.Sockets.AddressFamily.InterNetwork Then
    '            IPv4Address = ipheal.ToString()
    '        End If
    '    Next
    'End Function

    Public Sub initDBconn()
        'This is the connection for your MS SQL Server
        Dim dbName As String = "NSC"   'Database name

        'IP Address Connection String
        Dim userDB As String = "mfAdmin"
        Dim passDB As String = "mfAdmin"
        Dim ipDBName As String = "GymDB"   'Database name
        Dim ipAddressServer As String = "192.168.100.100"

        'REMOTE LOGIN
        'If connDB.State <> ConnectionState.Open Then connDB.ConnectionString = String.Format("Data Source={0},1433;Network Library=DBMSSOCN;Initial Catalog={1};User ID={2};Password={3};", ipAddressServer, ipDBName, userDB, passDB)
        'If connDB.State <> ConnectionState.Open Then connDB.Open()

        ''Local Database Login
        'If connDB.State <> ConnectionState.Open Then connDB.ConnectionString = String.Format("Data Source=.;Network Library=DBMSSOCN;Initial Catalog={1};User ID={2};Password={3};", IPv4Address(), ipDBName, userDB, passDB)
        'If connDB.State <> ConnectionState.Open Then connDB.Open()

        'Local Connection String
        If connDB.State <> ConnectionState.Open Then connDB.ConnectionString = "Data Source = .; Integrated Security = SSPI; Initial Catalog=" & ipDBName.Trim & ""
        If connDB.State <> ConnectionState.Open Then connDB.Open()

        With comDB
            .Connection = connDB
            .CommandType = CommandType.Text
            .CommandTimeout = 0
        End With
    End Sub

    'Close the connection from database
    Private Sub closeDB()
        If connDB.State <> ConnectionState.Closed Then connDB.Close()
    End Sub

    'Close DB Reader
    Private Sub closeReaderDB()
        If Not rdDB.IsClosed Then rdDB.Close()
    End Sub

    'Close both Reader and DB Connection
    Public Sub closeDBAll()
        Try
            If Not rdDB.IsClosed Then rdDB.Close()
            If connDB.State <> ConnectionState.Closed Then connDB.Close()
            SQLstr = Nothing

        Catch ex As Exception

        End Try
    End Sub

    Private SQLcmd As String

    Public Property SQLstr() As String
        Get
            Return SQLcmd
        End Get
        Set(ByVal value As String)
            SQLcmd = value
        End Set
    End Property


    'Select query passed here!
    Public Sub sqlQueryCMD(ByVal SQLstr As String)
        Try
            closeDBAll()
        Catch ex As Exception
        End Try
        initDBconn()
        With comDB
            .CommandText = SQLstr
            rdDB = .ExecuteReader
        End With
    End Sub

    'Insert, Update, Drop, Alter, Create query passed here!
    Public Sub sqlNonQueryCMD(ByVal SQLstr As String)
        Try
            closeDBAll()
        Catch ex As Exception
        End Try
        initDBconn()
        With comDB
            .CommandText = SQLstr
            .ExecuteNonQuery()
        End With
    End Sub


    Public Sub Delay(ByVal dblSecs As Double)
        Const OneSec As Double = 1.0# / (1440.0# * 60.0#)
        Dim dblWaitTil As Date
        Now.AddSeconds(OneSec)
        dblWaitTil = Now.AddSeconds(OneSec).AddSeconds(dblSecs)
        Do Until Now > dblWaitTil
            Application.DoEvents() 'Allow windows messages to be processed
        Loop
    End Sub

    Public Sub NumericTypeOnly(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or Asc(e.KeyChar) = 8 Or ((e.KeyChar = "." Or e.KeyChar = ",") And
                                                                   (sender.Text.IndexOf(".") = -1 And
                                                                    sender.Text.IndexOf(",") = -1)))

    End Sub
End Module
