using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class Student
{
    // Unused field removed for clarity.
    private string name;
    private string major;
    private DateTime startDate;
    private DateTime anticipatedGraduationDate;
    private string state;
    private string country;
    private string email;
    private bool restrictPersonalInfo;
    private string phone;
    private string mailingAddress;

    public static List<string> Log = new List<string>();

    public int ID { get; set; }

    public string Name
    {
        get => name;
        set
        {
            name = value;
            Log.Add($"Name updated");
        }
    }

    public string Major
    {
        get
        {
            if (restrictPersonalInfo)
                return "Restriced Personal Information";
            else
                return major;
        }
        set
        {
            major = value;
            Log.Add($"Major updated");
        }
    }

    public DateTime StartDate
    {
        get => startDate;
        set
        {
            startDate = value;
            Log.Add($"Start Date updated");
        }
    }

    public DateTime AnticipatedGraduationDate
    {
        get => anticipatedGraduationDate;
        set
        {
            anticipatedGraduationDate = value;
            Log.Add($"Anticipated Graduation Date updated");
        }
    }

    public string State
    {
        get
        {
            if (restrictPersonalInfo)
                return "Restriced Personal Information";
            else
                return state;
        }
        set
        {
            state = value;
            Log.Add($"State updated");
        }
    }

    public string Country
    {
        get
        {
            if (restrictPersonalInfo)
                return "Restriced Personal Information";
            else
                return country;
        }
        set
        {
            country = value;
            Log.Add($"Country updated");
        }
    }

    public string Email
    {
        get => email;
        set
        {
            if (!Regex.IsMatch(value, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
                throw new ArgumentException("Invalid email format!");
            email = value;
            Log.Add($"{DateTime.Now} - Email updated!");
        }
    }

    public string Phone
    {
        get
        {
            if (restrictPersonalInfo)
                return "Restriced Personal Information";
            else
                return phone;
        }
        set
        {
            phone = value;
            Log.Add($"{DateTime.Now} - Phone updated");
        }
    }

    public string MailingAddress
    {
        get
        {
            if (restrictPersonalInfo)
                return "Restriced Personal Information";
            else
                return mailingAddress;
        }
        set
        {
            mailingAddress = value;
            Log.Add($"Mailing Address updated");
        }
    }

    public bool RestrictPersonalInfo
    {
        get => restrictPersonalInfo;
        set
        {
            restrictPersonalInfo = value;
            Log.Add($"Privacy restriction updated");
        }
    }

    public Student(int id, string name, string email)
    {
        ID = id;
        Name = name;
        Email = email;
    }

    public Student(
        int id,
        string name,
        string email,
        string major,
        DateTime startDate,
        DateTime graduationDate,
        string state,
        string country,
        string phone,
        string address,
        bool restrictInfo
    )
    {
        ID = id;
        Name = name;
        Email = email;
        Major = major;
        StartDate = startDate;
        AnticipatedGraduationDate = graduationDate;
        State = state;
        Country = country;
        Phone = phone;
        MailingAddress = address;
        RestrictPersonalInfo = restrictInfo;
    }
}
