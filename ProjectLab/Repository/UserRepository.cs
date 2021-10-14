using ProjectLab.Factory;
using ProjectLab.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectLab.Repository
{
    public class UserRepository
    {
        static DatabaseEntities db = new DatabaseEntities();

        public static User Login(string username, string password)
        {
            User result = (from x in db.Users
                           where x.Username == username &&
                           x.Password == password
                           select x).FirstOrDefault();
            return result;
        }

        public static bool CheckUsernameIsEmpty(string username)
        {
            User result = (from x in db.Users
                           where x.Username == username
                           select x).FirstOrDefault();
            if (result == null)
            {
                return true;
            }
            else return false;
        }

        public static bool InsertUserMember(string username, string password,
            string name, string gender, int phone, string address)
        {
            User u = UserFactory.CreateUser(username, password, name, gender,
                phone, address);

            db.Users.Add(u);
            db.SaveChanges();
            return true;
        }

        public static bool UpdateProfile(User u, string username,
             string name, string gender, int phone, string address)
        {
            u.Username = username;
            u.Name = name;
            u.Gender = gender;
            u.PhoneNumber = phone;
            u.Address = address;
            db.SaveChanges();
            return true;
        }

        public static bool ChangePass(User u, string newPass)
        {
            u.Password = newPass;
            return true;
        }

        public static List<User> GetAllMember()
        {
            List<User> all = (from x in db.Users where x.RoleId == 1 select x).ToList();
            return all;
        }

        public static bool DeleteMember(int id)
        {
            User u = (from x in db.Users where x.UserId == id select x).FirstOrDefault();
            db.Users.Remove(u);
            db.SaveChanges();
            return true;
        }

        public static int getUserId()
        {
            User u = (User)HttpContext.Current.Session["User"];
            int id = u.UserId;
            return id;
        }





        //UAS
        //Artist
        public static bool addArtist(string id, string name,
            string dob, string birthCity, string genre, string gender, string telp)
        {
            Artist a = ArtistFactory.CreateArtist(name, dob, gender, birthCity,
                genre, gender, telp);

            db.Artist.Add(a);
            db.SaveChanges();
            return true;
        }

        public static bool updateArtist(Artist a, string id, string name,
            string dob, string birthCity, string genre, string gender, string telp)
        {
            a.idArtist = id;
            a.name = name;
            a.dob = dob;
            a.birthCity = birthCity;
            a.genre = genre;
            a.gender = gender;
            a.telp = telp;
            
            db.SaveChanges();
            
            return true;
        }

        public static bool deleteArtist(string id)
        {
            Artist a = (from x in db.Artist where x.idArtist.Equals(id) select x).FirstOrDefault();
            db.Artist.Remove(a);
            db.SaveChanges();
            return true;
        }

        //Manager
        public static bool addManager(string id, string name,
            string dob, string birthCity, string gender, string telp)
        {
            Manager m = ManagerFactory.CreateManager(name, dob, gender, birthCity,
                gender, telp);

            db.Manager.Add(m);
            db.SaveChanges();
            return true;
        }

        public static bool updateManager(Manager m, string id, string name,
            string dob, string birthCity, string gender, string telp)
        {
            m.idManager = id;
            m.name = name;
            m.dob = dob;
            m.birthCity = birthCity;
            m.gender = gender;
            m.telp = telp;

            db.SaveChanges();

            return true;
        }

        public static bool deleteManager(string id)
        {
            Manager m = (from x in db.Manager where x.idManager.Equals(id) select x).FirstOrDefault();
            db.Manager.Remove(m);
            db.SaveChanges();
            return true;
        }

        //Address
        public static bool addAddress(string street, string streetNumber,
             string zipCode, string city, string country)
        {
            Address a = AddressFactory.CreateArtist(street, streetNumber, zipCode,
                city, country);

            db.Address.Add(a);
            db.SaveChanges();
            return true;
        }

        public static Address findAddress(string street, string streetNumber,
            string zipCode, string city, string country)
        {
            return (from x in db.Address where x.street.Equals(street),
                x.streetNumber.Equals(streetNumber), x.zipCode.Equals(zipCode)
                , x.city.Equals(city), x.country.Equals(country) select x).FirstOrDefault();
        }

        public static bool updateAddress(string street, string streetNumber,
            string zipCode, string city, string country)
        {
            Address a = AddressRepository.findAddress(street, streetNumber,
                zipCode, city, country);

            a.street = street;
            a.streetNumber = streetNumber;
            a.zipCode = zipCode;
            a.city = city;
            a.country = country;

            db.SaveChanges();

            return true;
        }

        public static bool deleteArtist(string street, string streetNumber,
            string zipCode, string city, string country)
        {
            Address a = AddressRepository.findAddress(street, streetNumber,
                zipCode, city, country);

            db.Address.Remove(a);
            db.SaveChanges();
            return true;
        }

        //Schedule
        public static bool addSchedule(string idSchedule, string idArtist,
            string idManager, string type, string date, string time, string place,
            string notes)
        {
            Address a = AddressFactory.CreateAddress(idSchedule, idArtist, idManager,
                type, date, time, place, notes);

            db.Address.Add(a);
            db.SaveChanges();
            return true;
        }

        public static bool updateSchedule(Schedule s, string idSchedule, string idArtist,
            string idManager, string type, string date, string time, string place,
            string notes)
        {
            s.idSchedule = idSchedule;
            s.idArtist = idArtist;
            s.idManager = idManager;
            s.type = type;
            s.date = date;
            s.time = time;
            s.place = place;
            s.notes = notes;

            db.SaveChanges();

            return true;
        }

        public static bool deleteSchedule(string id)
        {
            Schedule s = (from x in db.Schedule where x.idSchedule.Equals(id) select x).FirstOrDefault();
            db.Schedule.Remove(s);
            db.SaveChanges();
            return true;
        }

        //Music
        public static bool addMusic(string idMusic, string idArtist,
            string title, string genre, string releaseDate, string labelMusic)
        {
            Music m = MusicFactory.CreateMusic(idMusic, idArtist, title,
                genre, releaseDate, labelMusic);

            db.Music.Add(m);
            db.SaveChanges();
            return true;
        }

        public static bool updateMusic(Music m, string idMusic, string idArtist,
            string title, string genre, string releaseDate, string labelMusic)
        {
            m.idMusic = idMusic;
            m.idArtist = idArtist;
            m.title = title;
            m.genre = genre;
            m.releaseDate = releaseDate;
            m.labelMusic = labelMusic;

            db.SaveChanges();

            return true;
        }

        //Contract
        public static bool addContract(string idContract, string idMusic,
            string buyer, string type, string timeLength, long price, string file)
        {
            Contract c = ContractFactory.CreateContract(idContract, idMusic, buyer,
                type, timeLength, price, file);

            db.Contract.Add(c);
            db.SaveChanges();
            return true;
        }

        public static bool finishedContract(string id)
        {
            Contract c = (from x in db.Contract where x.idContract.Equals(id) select x).FirstOrDefault();
            db.Contract.Remove(c);
            db.SaveChanges();
            return true;
        }

        //History
        public static bool addHistory(string idHistory, string idContract,
            string idArtist, string transactionType, string buyer, string date,
            string notes, long price)
        {
            History h = HistoryFactory.CreateHistory(idHistory, idContract,
                idArtist, transactionType, buyer, date, notes, price);

            db.History.Add(h);
            db.SaveChanges();
            return true;
        }
    }
}