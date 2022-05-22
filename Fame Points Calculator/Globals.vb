Imports System.Data.SQLite
Imports System.Text
Imports System.Xml
Imports Newtonsoft.Json

Module Globals
    Public conn As New SQLiteConnection("Data Source=C:\Users\sisso\Desktop\python\fame-points\db.db")
    Public cmd As New SQLiteCommand("", conn)
    Public Reader As SQLiteDataReader

    Public APIID As String = "0736c8bb8838d6b17b7e7f29b8a319ee"
    Public APIRealm As String = "eu"
    Public APILang As String = "en"

    Public EventID As String = "renaissance"
    Public FrontID As String = "renaissance_bg"

    Public AccountID As String = "542250529"
    Public NickName As String = "Mimoteb"
    Public ClanName As String = ""
    Public ClanTag As String = ""



    Public Function Json2XML(ByVal json As String) As XmlDocument
        Return JsonConvert.DeserializeXmlNode(json, "Root")
    End Function
    Public Function DownloadAPI(ByVal Link As String) As XmlDocument
        Try
            Dim str As String
            Using client As New Net.WebClient
                client.Encoding = Encoding.UTF8
                str = client.DownloadString(Link)
            End Using
            DownloadAPI = Json2XML(str)
        Catch ex As Exception
            DownloadAPI = Nothing
            MsgBox(ex.Message)
        End Try
        Return DownloadAPI
    End Function
    Public Function GetPointsCutByRank(ByVal Rank As Integer) As String
        Dim link As String = String.Format("https://api.worldoftanks.eu/wot/globalmap/eventaccountratings/?application_id={0}&front_id={1}&event_id={2}&page_no={3}&limit=10&in_rating=1", APIID, FrontID, EventID, Math.Ceiling(Rank / 10))
        Dim Doc As XmlDocument = DownloadAPI(link)
        Dim AccountRank As String
        GetPointsCutByRank = Nothing
        Dim AccountAwardLevel As String
        Dim AccountRankDelta As String
        Dim AccountFamePointsToImproveAward As String
        Dim AccountUpdatedAt As String
        Dim AccountBattles As String
        Dim AccountClanRank As String
        Dim AccountClanID As String
        Dim AccountBattlesToAward As String
        Dim AccountFamePoints As String
        For Each item As XmlNode In Doc.ChildNodes(0)
            If item.ChildNodes(0).InnerText IsNot Nothing And item.ChildNodes(0).InnerText = Rank.ToString Then
                AccountRank = item.ChildNodes(0).InnerText
                AccountAwardLevel = item.ChildNodes(1).InnerText
                AccountRankDelta = item.ChildNodes(4).InnerText
                AccountFamePointsToImproveAward = item.ChildNodes(5).InnerText
                AccountUpdatedAt = item.ChildNodes(6).InnerText
                AccountBattles = item.ChildNodes(7).InnerText
                AccountClanRank = item.ChildNodes(8).InnerText
                AccountClanID = item.ChildNodes(9).InnerText
                AccountBattlesToAward = item.ChildNodes(11).InnerText
                AccountFamePoints = item.ChildNodes(12).InnerText
                GetPointsCutByRank = AccountFamePoints
            End If
        Next

        Return GetPointsCutByRank
    End Function
    Public Function GetGMRank() As String
        GetGMRank = Nothing
        Return GetGMRank
    End Function
End Module
