Imports System.Threading

Public Class Form1
    Dim dtMain As DataTable = New DataTable("dtMain")
    Dim dtB As DataTable = New DataTable("dtB")
    Dim dtC As DataTable = New DataTable("dtC")
    Dim dtD As DataTable = New DataTable("dtD")

    Dim tableDict As Dictionary(Of String, DataTable) = New Dictionary(Of String, DataTable)()

    Dim r As Random = New Random()

    Dim weaks As WeakReference()

    Dim threadCount As Integer = 0

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        tableDict.Add(dtMain.TableName, dtMain)
        tableDict.Add(dtB.TableName, dtB)
        tableDict.Add(dtC.TableName, dtC)
        tableDict.Add(dtD.TableName, dtD)

        tableDict.Add("ColB", dtB)
        tableDict.Add("ColC", dtC)
        tableDict.Add("ColD", dtD)

        'DT main data columns
        Dim c As DataColumn = New DataColumn()
        c.ColumnName = "colA"
        c.DataType = GetType(String)
        dtMain.Columns.Add(c)

        c = New DataColumn()
        c.ColumnName = "ColB"
        c.DataType = GetType(Integer)
        dtMain.Columns.Add(c)

        c = New DataColumn()
        c.ColumnName = "ColC"
        c.DataType = GetType(Integer)
        dtMain.Columns.Add(c)

        c = New DataColumn()
        c.ColumnName = "ColD"
        c.DataType = GetType(Integer)
        dtMain.Columns.Add(c)


        c = New DataColumn()
        c.ColumnName = "colE"
        c.DataType = GetType(Long)
        dtMain.Columns.Add(c)

        c = New DataColumn()
        c.ColumnName = "colF"
        c.DataType = GetType(Double)
        dtMain.Columns.Add(c)

        'dtB
        c = New DataColumn()
        c.ColumnName = "val"
        c.DataType = GetType(Integer)
        dtB.Columns.Add(c)

        c = New DataColumn()
        c.ColumnName = "display"
        c.DataType = GetType(String)
        dtB.Columns.Add(c)

        c = New DataColumn()
        c.ColumnName = "colE"
        c.DataType = GetType(Long)
        dtB.Columns.Add(c)

        c = New DataColumn()
        c.ColumnName = "colF"
        c.DataType = GetType(Double)
        dtB.Columns.Add(c)

        'dtC
        c = New DataColumn()
        c.ColumnName = "val"
        c.DataType = GetType(Integer)
        dtC.Columns.Add(c)

        c = New DataColumn()
        c.ColumnName = "display"
        c.DataType = GetType(String)
        dtC.Columns.Add(c)

        'dtD
        c = New DataColumn()
        c.ColumnName = "val"
        c.DataType = GetType(Integer)
        dtD.Columns.Add(c)

        c = New DataColumn()
        c.ColumnName = "display"
        c.DataType = GetType(String)
        dtD.Columns.Add(c)

        c = New DataColumn()
        c.ColumnName = "colE"
        c.DataType = GetType(Long)
        dtD.Columns.Add(c)

        c = New DataColumn()
        c.ColumnName = "colF"
        c.DataType = GetType(Double)
        dtD.Columns.Add(c)

        c = New DataColumn()
        c.ColumnName = "colG"
        c.DataType = GetType(Long)
        dtD.Columns.Add(c)

        c = New DataColumn()
        c.ColumnName = "colH"
        c.DataType = GetType(Double)
        dtD.Columns.Add(c)

        addRows(dtB, r.Next(15, 30))

        addRows(dtC, r.Next(150, 300))

        addRows(dtD, r.Next(1500, 3000))

        'Setup dgv
        For Each col As DataGridViewColumn In DGV1.Columns
            If TypeOf (col) Is DataGridViewComboBoxColumn Then
                Dim cmb As DataGridViewComboBoxColumn = CType(col, DataGridViewComboBoxColumn)
                cmb.DataSource = tableDict(cmb.Name)
                cmb.DataPropertyName = "val"
                cmb.ValueMember = "val"
                cmb.DisplayMember = "display"
            End If
        Next

    End Sub
    Private Sub BTN_Fill_Click(sender As Object, e As EventArgs) Handles BTN_Fill.Click
        If DGV1.Rows.Count > 1 Then
            consoleOut("DGV Has rows, can't fill")
            Return
        End If
        consoleOut("Ensuring min rows")
        If dtMain.Rows.Count < CInt(NUD_Rows.Value) Then
            addRows(dtMain, CInt(NUD_Rows.Value) - dtMain.Rows.Count)
        End If

        consoleOut("Filling DGV")
        DGV1.RowCount = CInt(NUD_Rows.Value)
        weaks = New WeakReference(CInt(NUD_Rows.Value) - 1) {}

        For i As Integer = 0 To CInt(NUD_Rows.Value) - 1
            Dim dgvr As DataGridViewRow = DGV1.Rows(i)
            Dim dr As DataRow = dtMain.Rows(i)
            weaks(i) = New WeakReference(DGV1.Rows(i))
            For Each col As DataGridViewColumn In DGV1.Columns
                dgvr.Cells(col.Name).Value = dr(col.Name)
            Next
        Next

        consoleOut("Filled")

    End Sub

    Private Sub consoleOut(v As String)
        TB_Console.AppendText(v + vbNewLine)
    End Sub

    Private Sub addRows(dt As DataTable, cnt As Integer)
        Dim s As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ .,()-+=?!@#abcdefghijklmnopqrstuvwxyz0123456789"

        Dim lastIndex As Integer = -1
        If dt IsNot dtMain Then
            If dt.Rows.Count = 0 Then
                lastIndex = 0
            Else
                lastIndex = dt.Rows(dt.Rows.Count - 1)("val")
            End If
        End If

        For i As Integer = 0 To cnt - 1
            If r.Next(15) = 10 Then
                lastIndex += r.Next(2, 99)
            Else
                lastIndex += 1
            End If


            Dim dr As DataRow = dt.NewRow()
            For Each c As DataColumn In dt.Columns
                If c.DataType = GetType(String) Then
                    Dim sLen As Integer = r.Next(5, 100)
                    Dim sRes As String = ""
                    For si As Integer = 0 To sLen - 1
                        sRes += s.Chars(r.Next(0, s.Length))
                    Next
                    dr(c.ColumnName) = sRes

                ElseIf c.DataType = GetType(Long) Then
                    dr(c.ColumnName) = r.Next()

                ElseIf c.DataType = GetType(Double) Then
                    dr(c.ColumnName) = r.NextDouble()

                ElseIf c.DataType = GetType(Integer) Then
                    If dt IsNot dtMain Then
                        dr(c.ColumnName) = lastIndex
                    Else
                        Dim parTable As DataTable = tableDict(c.ColumnName)
                        dr(c.ColumnName) = parTable(r.Next(parTable.Rows.Count))("val")
                    End If
                End If

            Next
            dt.Rows.Add(dr)
        Next


    End Sub

    Private Sub Btn_Simple_Clear_Click(sender As Object, e As EventArgs) Handles btn_Simple_Clear.Click

        consoleOut("Clearing rows")
        DGV1.Rows.Clear()
        consoleOut("Done Clearing rows")
    End Sub

    Private Sub BTN_Report_Click(sender As Object, e As EventArgs) Handles BTN_Report.Click
        Dim livingRows As Integer = 0
        For i As Integer = 0 To weaks.Length - 1
            If weaks(i).IsAlive Then
                livingRows += 1
            End If
        Next
        consoleOut(String.Format("GC bytes {0}, living rows {1} ", GC.GetTotalMemory(True), livingRows))
    End Sub

    Private Sub BTN_GC_Click(sender As Object, e As EventArgs) Handles BTN_GC.Click
        consoleOut("GC")
        GC.Collect()
        GC.WaitForPendingFinalizers()
        GC.Collect()
        consoleOut("Done GC")
    End Sub

    Private Sub BTN_Custom_Clear_Click(sender As Object, e As EventArgs) Handles BTN_Custom_Clear.Click
        Dim dt As DateTime = DateTime.Now()
        Dim ts As TimeSpan
        'Get all combo columns
        Dim cols As List(Of Integer) = New List(Of Integer)
        For Each c As DataGridViewColumn In DGV1.Columns
            If TypeOf (c) Is DataGridViewComboBoxColumn Then
                cols.Add(c.Index)
            End If
        Next

        Dim rows As DataGridViewRow() = New DataGridViewRow(DGV1.RowCount - 1) {}
        DGV1.Rows.CopyTo(rows, 0)

        If RB_MainThread.Checked Then
            consoleOut("Doing this on main!")
            DGV1.Rows.Clear()
            Interlocked.Increment(threadCount)
            Dim tdp = New TearDownParms(rows, cols, 0, rows.Count - 1)
            Teardown_DGV_Rows(tdp)
            ts = DateTime.Now - dt
            consoleOut("Finished in " + ts.ToString())
        Else
            Dim chunks As Integer = CInt(NUD_Threads.Value)
            consoleOut("Doing this on threads in " + chunks.ToString() + " chunks")
            DGV1.Rows.Clear()
            Dim size As Integer = rows.Count \ chunks
            Dim max As Integer = 0
            For i As Integer = 0 To chunks - 2
                Interlocked.Increment(threadCount)
                max = (i + 1) * size - 1
                ThreadPool.QueueUserWorkItem(AddressOf Teardown_DGV_Rows, New TearDownParms(rows, cols, i * size, max))
            Next
            Interlocked.Increment(threadCount)
            ThreadPool.QueueUserWorkItem(AddressOf Teardown_DGV_Rows, New TearDownParms(rows, cols, max, rows.Count - 1))
        End If

        'now we wait
        While threadCount <> 0
            'with the amount of time taken here 1s is not going to ruin my timing
            Thread.Sleep(1000)
        End While
        ts = DateTime.Now - dt
        consoleOut("Finished in " + ts.ToString())
    End Sub

    Private Sub Teardown_DGV_Rows(state As Object)
        Dim tdp As TearDownParms = CType(state, TearDownParms)
        For i As Integer = tdp.startNDX To tdp.stopNDX
            If tdp.rows(i) IsNot Nothing Then
                For Each c As Integer In tdp.colNDXS

                    Dim cell As DataGridViewComboBoxCell = tdp.rows(i).Cells(c)
                    cell.DataSource = Nothing
                    cell = Nothing
                Next
                tdp.rows(i) = Nothing
            End If
        Next
        Interlocked.Decrement(threadCount)
    End Sub

    Private Sub BTN_KWClear_Click(sender As Object, e As EventArgs) Handles BTN_KWClear.Click
        consoleOut("Doing this Kyle's way!")
        Dim dt As DateTime = DateTime.Now()
        DGV1.SuspendLayout()
        For i As Integer = 0 To DGV1.Rows.Count - 1
            For Each c As DataGridViewColumn In DGV1.Columns
                If TypeOf (c) Is DataGridViewComboBoxColumn Then
                    CType(DGV1(c.Index, i), DataGridViewComboBoxCell).DataSource = Nothing
                End If
            Next
        Next
        DGV1.Rows.Clear()
        DGV1.ResumeLayout()

        Dim ts As TimeSpan = DateTime.Now - dt
        consoleOut("Finished in " + ts.ToString())
    End Sub
End Class

Class TearDownParms
    Public startNDX As Integer
    Public stopNDX As Integer
    Public rows As DataGridViewRow()
    Public colNDXS As List(Of Integer)



    Public Sub New(rows() As DataGridViewRow, cols As List(Of Integer), start As Integer, [stop] As Integer)
        Me.rows = rows
        Me.colNDXS = cols
        Me.startNDX = start
        Me.stopNDX = [stop]
    End Sub
End Class
