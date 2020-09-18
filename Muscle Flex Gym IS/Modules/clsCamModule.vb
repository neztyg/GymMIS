Imports System.Runtime.InteropServices
Imports System.IO

Public Class clsCamModule

    Const WM_CAP As Short = &H400S

    Const WM_CAP_DRIVER_CONNECT As Integer = WM_CAP + 10
    Const WM_CAP_DRIVER_DISCONNECT As Integer = WM_CAP + 11
    Const WM_CAP_EDIT_COPY As Integer = WM_CAP + 30

    Const WM_CAP_SET_PREVIEW As Integer = WM_CAP + 50
    Const WM_CAP_SET_PREVIEWRATE As Integer = WM_CAP + 52
    Const WM_CAP_SET_SCALE As Integer = WM_CAP + 53
    Const WS_CHILD As Integer = &H40000000
    Const WS_VISIBLE As Integer = &H10000000
    Const SWP_NOMOVE As Short = &H2S
    Const SWP_NOSIZE As Short = 1
    Const SWP_NOZORDER As Short = &H4S
    Const HWND_BOTTOM As Short = 1
    Public iDevice As Integer = 0 ' Current device ID
    Dim hHwnd As Integer ' Handle to preview window

    Declare Function SendMessage Lib "user32" Alias "SendMessageA" _
        (ByVal hwnd As Integer, ByVal wMsg As Integer, ByVal wParam As Integer,
        <MarshalAs(UnmanagedType.AsAny)> ByVal lParam As Object) As Integer

    Declare Function SetWindowPos Lib "user32" Alias "SetWindowPos" (ByVal hwnd As Integer,
        ByVal hWndInsertAfter As Integer, ByVal x As Integer, ByVal y As Integer,
        ByVal cx As Integer, ByVal cy As Integer, ByVal wFlags As Integer) As Integer

    Declare Function DestroyWindow Lib "user32" (ByVal hndw As Integer) As Boolean

    Declare Function capCreateCaptureWindowA Lib "avicap32.dll" _
        (ByVal lpszWindowName As String, ByVal dwStyle As Integer,
        ByVal x As Integer, ByVal y As Integer, ByVal nWidth As Integer,
        ByVal nHeight As Short, ByVal hWndParent As Integer,
        ByVal nID As Integer) As Integer

    Declare Function capGetDriverDescriptionA Lib "avicap32.dll" (ByVal wDriver As Short,
        ByVal lpszName As String, ByVal cbName As Integer, ByVal lpszVer As String,
        ByVal cbVer As Integer) As Boolean


    Public Sub OpenPreviewWindow(ByVal devID As String, ByVal imgHolder As Object)
        Dim iHeight As Integer = imgHolder.Height
        Dim iWidth As Integer = imgHolder.Width
        hHwnd = capCreateCaptureWindowA(devID, WS_VISIBLE Or WS_CHILD, 0, 0, iWidth,
            iHeight, imgHolder.Handle.ToInt32, 0)
        If SendMessage(hHwnd, WM_CAP_DRIVER_CONNECT, 0, 0) Then
            SendMessage(hHwnd, WM_CAP_SET_SCALE, True, 0)
            SendMessage(hHwnd, WM_CAP_SET_PREVIEWRATE, 66, 0)
            SendMessage(hHwnd, WM_CAP_SET_PREVIEW, True, 0)
            SetWindowPos(hHwnd, HWND_BOTTOM, 0, 0, iHeight, iWidth,
                    SWP_NOMOVE Or SWP_NOZORDER)

            SendKeys.Send("{TAB}")

        Else
            DestroyWindow(hHwnd)
        End If
    End Sub


    Private devList(5) As String
    Public Function LoadDeviceList()
        Dim strName As String = Space(100)
        Dim strVer As String = Space(100)
        Dim bReturn As Boolean
        Dim x As Integer = 0
        Do
            bReturn = capGetDriverDescriptionA(x, strName, 100, strVer, 100)
            If bReturn Then devList.SetValue(strName.Trim, x)
            x += 1
        Loop Until bReturn = False Or devList.Length = x

        Return devList(0)
    End Function

    Public Sub ClosePreviewWindow()
        SendMessage(hHwnd, WM_CAP_DRIVER_DISCONNECT, iDevice, 0)
        DestroyWindow(hHwnd)
    End Sub

    Private imagePath As String
    Public Property imgURL() As String
        Get
            Return imagePath
        End Get
        Set(ByVal value As String)
            imagePath = value
        End Set
    End Property

    Public Sub captureImage(ByVal imgFileName As String, ByVal imgHolder As Windows.Forms.PictureBox)

        Dim folderPath As String = System.IO.Path.GetTempPath() + "MFGymApp\temp_images\"
        Dim filePath As String = folderPath & imgFileName

        Dim data As IDataObject
        Dim bmap As Image


        SendMessage(hHwnd, WM_CAP_EDIT_COPY, 200, 200)
        data = Clipboard.GetDataObject()

        If Not Directory.Exists(folderPath) Then
            Directory.CreateDirectory(folderPath)
        End If

        'For Each foundFile As String In My.Computer.FileSystem.GetFiles(
        '                    folderPath, FileIO.SearchOption.SearchAllSubDirectories, "*.*")
        '    Try
        '        My.Computer.FileSystem.DeleteFile(foundFile,
        '                                          FileIO.UIOption.OnlyErrorDialogs,
        '                                          FileIO.RecycleOption.DeletePermanently,
        '                                          FileIO.UICancelOption.DoNothing)
        '    Catch ex As Exception

        '    End Try
        'Next


        If data.GetDataPresent(GetType(System.Drawing.Bitmap)) Then
            bmap = CType(data.GetData(GetType(System.Drawing.Bitmap)), Image)
            bmap.Save(filePath, Imaging.ImageFormat.Jpeg)
            imgHolder.Image = Image.FromFile(filePath)
            imgURL = filePath

        End If

    End Sub


    Public Sub takePicI(ByVal imgHolder As Windows.Forms.PictureBox)

    End Sub

End Class
