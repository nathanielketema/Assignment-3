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
    private string phone;
    private string mailingAddress;
    private bool restrictPersonalInfo;

    public static List<string> Log = new List<string>();

    public int ID { get; set; }

    public string Name
    {
        get => name;
        set
        {
            name = value;
            Log.Add($"{DateTime.Now} - Name updated!");
        }
    }

    public string Major
    {
        get
        {
            if (restrictPersonalInfo)
                return "Access not granted!";
            else
                return major;
        }
        set
        {
            major = value;
            Log.Add($"{DateTime.Now} - Major updated!");
        }
    }

    public DateTime StartDate
    {
        get
        {
            if (restrictPersonalInfo)
                throw new UnauthorizedAccessException("Access not granted!");
            else
                return startDate;
        }
        set
        {
            startDate = value;
            Log.Add($"{DateTime.Now} - Start Date updated!");
        }
    }

    public DateTime AnticipatedGraduationDate
    {
        get
        {
            if (restrictPersonalInfo)
                throw new UnauthorizedAccessException("Access not granted!");
            else
                return anticipatedGraduationDate;
        }
        set
        {
            anticipatedGraduationDate = value;
            Log.Add($"{DateTime.Now} - Anticipated Graduation Date updated!");
        }
    }

    public string State
    {
        get
        {
            if (restrictPersonalInfo)
                return "Access not granted!";
            else
                return state;
        }
        set
        {
            state = value;
            Log.Add($"{DateTime.Now} - State updated!");
        }
    }

    public string Country
    {
        get
        {
            if (restrictPersonalInfo)
                return "Access not granted!";
            else
                return country;
        }
        set
        {
            country = value;
            Log.Add($"{DateTime.Now} - Country updated!");
        }
    }

    public string Email
    {
        get => email;
        set
        {
            if (!Regex.IsMatch(value, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
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
                return "Access not granted!";
            else
                return phone;
        }
        set
        {
            if (!Regex.IsMatch(value, @"^\d{10}$"))
                throw new ArgumentException("Invalid phone format!");
            phone = value;
            Log.Add($"{DateTime.Now} - Phone updated!");
        }
    }

    public string MailingAddress
    {
        get
        {
            if (restrictPersonalInfo)
                return "Access not granted!";
            else
                return mailingAddress;
        }
        set
        {
            mailingAddress = value;
            Log.Add($"{DateTime.Now} - Mailing Address updated!");
        }
    }

    public bool RestrictPersonalInfo
    {
        get => restrictPersonalInfo;
        set
        {
            restrictPersonalInfo = value;
            Log.Add($"{DateTime.Now} - Privacy restriction updated!");
        }
    }

    public Student(int id, string name, string email)
    {
        ID = id;
        Name = name;
        Email = email;
    }

    public Student(int id, string name, string email, string major, DateTime startDate,
            DateTime graduationDate, string state, string country, string phone,
            string address, bool restrictInfo)
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
