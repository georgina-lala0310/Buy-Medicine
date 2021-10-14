using ProjectLab.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectLab.Factory
{
    public class UserFactory
    {
        public static User CreateUser(string username, string password, 
            string name, string gender, int phone, string address)
        {
            User u = new User();
            u.RoleId = 1;
            u.Username = username;
            u.Password = password;
            u.Name = name;
            u.Gender = gender;
            u.PhoneNumber = phone;
            u.Address = address;

            return u;
        }

        //UAS

        //public static Artist CreateArtist(string id, string name,
        //    string dob, string birthCity, string genre, string gender, string telp)
        //{
        //    Artist a = new Artist();
        //    a.idArtist = id;
        //    a.name = name;
        //    a.dob = dob;
        //    a.birthCity = birthCity;
        //    a.genre = genre;
        //    a.gender = gender;
        //    a.telp = telp;

        //    return a;
        //}

        //public static Manager CreateManager(string id, string name,
        //    string dob, string birthCity, string gender, string telp)
        //{
        //    Manager m = new Manager();
        //    m.idArtist = id;
        //    m.name = name;
        //    m.dob = dob;
        //    m.birthCity = birthCity;
        //    m.gender = gender;
        //    m.telp = telp;

        //    return m;
        //}

        //public static Address CreateAddress(string street, string streetNumber,
        //    string zipCode, string city, string country)
        //{
        //    Address a = new Address();
        //    a.street = street;
        //    a.streetNumber = streetNumber;
        //    a.zipCode = zipCode;
        //    a.city = city;
        //    a.country = country;

        //    return a;
        //}

        //public static Schedule CreateSchedule(string idSchedule, string idArtist,
        //    string idManager, string type, string date, string time, string place,
        //    string notes)
        //{
        //    Schedule s = new Schedule();
        //    s.idSchedule = idSchedule;
        //    s.idArtist = idArtist;
        //    s.idManager = idManager;
        //    s.type = type;
        //    s.date = date;
        //    s.time = time;
        //    s.place = place;
        //    s.notes = notes;

        //    return s;
        //}

        //public static Music CreateMusic(string idMusic, string idArtist,
        //    string title, string genre, string releaseDate, string labelMusic)
        //{
        //    Music m = new Music();
        //    m.idMusic = idMusic;
        //    m.idArtist = idArtist;
        //    m.title = title;
        //    m.genre = genre;
        //    m.releaseDate = releaseDate;
        //    m.labelMusic = labelMusic;

        //    return m;
        //}

        //public static Contract CreateContract(string idContract, string idMusic,
        //    string buyer, string type, string timeLength, long price, string file)
        //{
        //    Contract c = new Contract();
        //    c.idContract = idContract;
        //    c.idMusic = idMusic;
        //    c.buyer = buyer;
        //    c.type = type;
        //    c.timeLength = timeLength;
        //    c.price = price;
        //    c.file = file;

        //    return c;
        //}

        //public static History CreateHistory(string idHistory, string idContract,
        //    string idArtist, string transactionType, string buyer, string date,
        //    string notes, long price)
        //{
        //    History h = new History();
        //    h.idHistory = idHistory;
        //    h.idContract = idContract;
        //    h.idArtist = idArtist;
        //    h.transactionType = transactionType;
        //    h.buyer = buyer;
        //    h.date = date;
        //    h.notes = notes;
        //    h.price = price;

        //    return h;
        //}
    }
}