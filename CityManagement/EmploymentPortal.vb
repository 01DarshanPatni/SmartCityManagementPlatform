﻿Public Class EmploymentPortal
    'Public hosProposalForm As New HosProposal(Me)
    Private Sub EmploymentPortal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load ListOfOrganizationsForm into the innerPanel
        Panel1.Controls.Clear()
        ShowFormInPanel(New EmployOrgList(Me))
        CurvedLabel1.Visible = False
    End Sub

    Public Sub ShowFormInPanel(formToShow As Form)
        ' Clear Panel1
        Panel1.Controls.Clear()

        ' Set the properties of the form to be displayed inside Panel1
        formToShow.TopLevel = False
        formToShow.FormBorderStyle = FormBorderStyle.None
        formToShow.Dock = DockStyle.Fill

        ' Add the form to Panel1
        Panel1.Controls.Add(formToShow)

        ' Show the form
        formToShow.Show()

    End Sub

    Public Sub LoadListOfOrgForm()
        ' Load ListOfOrgForm into Panel1
        CurvedLabel1.Visible = False
        ShowFormInPanel(New EmployOrgList(Me))
    End Sub

    Public Sub LoadRegularServicesForm()
        ' Load RegularServicesForm into Panel1
        CurvedLabel1.Visible = False
        ShowFormInPanel(New RegularServicesList(Me))
    End Sub

    Public Sub LoadDoctorEmploymentForm()
        ' Load DoctorEmploymentForm into Panel1
        CurvedLabel1.Visible = False
        ShowFormInPanel(New Health_DoctorsEmployment(Me))
    End Sub

    Public Sub LoadApplicationForm()
        ' Load ApplicationForm into Panel1
        CurvedLabel1.Visible = False
        ShowFormInPanel(New EmployApplication(Me))
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'ShowFormInPanel(hosProposalForm)
        ShowFormInPanel(New Health_HospitalListing(Me))
        CurvedLabel1.Visible = True
    End Sub

End Class