using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusReservationSystem.PresistenceLayer
{
    class DBAccess
    {
        private BusReservationEntities db;
        public DBAccess()
        {
            db = new BusReservationEntities();
        }
        public List<BusInfo> GetFullBookedBuses()
        {
            List<BusInfo> busList = new List<BusInfo>();
            var buses = this.GetAllBuses();
            for(int i = 0; i < buses.Count; i++)
            {
                int id = (int)buses[i].id;
                int count = db.SeatInfoes.Count(me => me.BusId == id);
                if (count==39)
                {
                    busList.Add(db.BusInfoes.Where(a => a.id == id).FirstOrDefault());
                }
            }
            return busList;
        }
        public List<BusInfo> GetAllBuses()
        {
            return db.BusInfoes.ToList();
        }
        public List<Customer> GetAllCustomers()
        {
            return db.Customers.ToList();
        }
        public List<TicketDetail> GetAllBookings()
        {
            return db.TicketDetails.ToList();
        }

        public List<BusInfo> getEmptyBuses()
        {
            List<BusInfo> busList = new List<BusInfo>();
            var buses = this.GetAllBuses();
            for (int i = 0; i < buses.Count; i++)
            {
                int id = (int)buses[i].id;
                int count = db.SeatInfoes.Count(me => me.BusId == id);
                if (count == 0)
                {
                    busList.Add(db.BusInfoes.Where(a => a.id == id).FirstOrDefault());
                }
            }
            return busList;
        }

        public List<BusInfo> GetBusesByNo(string busNo)
        {
            return db.BusInfoes.Where(a => a.BusNo.Equals(busNo)).ToList();
        }
        public List<BusInfo> GetBusesByID(string id)
        {
            return db.BusInfoes.Where(a => a.id==int.Parse(id)).ToList();
        }
        public List<BusInfo> GetBusesBySource(string sour)
        {
            return db.BusInfoes.Where(a => a.Source.Equals(sour)).ToList();
        }
        public List<BusInfo> GetBusesByDestination(string des)
        {
            return db.BusInfoes.Where(a => a.Destination.Equals(des)).ToList();
        }
        public List<BusInfo> GetBusesByFare(string fare)
        {
            return db.BusInfoes.Where(a => a.Fare == int.Parse(fare)).ToList();
        }
        public void DeleteFromBusInfo(int id)
        {
            var busDate = db.BusInfoes.Where(c => c.id == id).FirstOrDefault();
            if (busDate != null)
            {
                try
                {
                    db.BusInfoes.Remove(busDate);
                    db.SaveChanges();
                }
                catch (Exception) { }
            }
        }
        public void InsertBus(string bno,string bclass,string so,string des,string dep,string ar,string fa)
        {
            db.BusInfoes.Add(new BusInfo
            {
                BusNo = bno,
                BusClass = bclass,
                Source = so,
                Destination = des,
                DepartureTime = dep,
                ArivalTime = ar,
                Fare = int.Parse(fa)
            });
            db.SaveChanges();
        }
        public int InsertCustomer(string nametxt, string fnametxt, DateTime birthdate, string emailtext, string phonetxt, string addresstext)
        {
            Customer customers = new Customer
            {
                Name = nametxt,
                FatherName = fnametxt,
                DateOfBirth = birthdate,
                Email = emailtext,
                PhoneNo = phonetxt,
                Address = addresstext
            };
            db.Customers.Add(customers);
            db.SaveChanges();
            return customers.Id;
        }
        public void InsertLogin(int id,string nametxt, string passtxt)
        {
            db.Logins.Add(new Login
            {
                custId = id,
                username = nametxt,
                password = passtxt
            });
            db.SaveChanges();
        }

        public void DeleteCustomer(int id)
        {
            var cust = db.Customers.Where(a => a.Id == id).FirstOrDefault();
            if (cust != null)
            {
                try {
                    db.Customers.Remove(cust);
                    db.SaveChanges();
                } catch (Exception) { }
            }
        }
        public List<Customer> GetBookCustomers()
        {
            List<Customer> custL = new List<Customer>();
            var custs = this.GetAllCustomers();
            for (int i = 0; i < custs.Count; i++)
            {
                int id = (int)custs[i].Id;
                int count = db.SeatInfoes.Count(me => me.custId == id);
                if (count > 0)
                {
                    custL.Add(db.Customers.Where(a => a.Id == id).FirstOrDefault());
                }
            }
            return custL;
        }
        public List<Customer> GetNoMakeBookCustomers()
        {
            List<Customer> custL = new List<Customer>();
            var custs = this.GetAllCustomers();
            for (int i = 0; i < custs.Count; i++)
            {
                int id = (int)custs[i].Id;
                int count = db.SeatInfoes.Count(me => me.custId == id);
                if (count == 0)
                {
                    custL.Add(db.Customers.Where(a => a.Id == id).FirstOrDefault());
                }
            }
            return custL;
        }
        public List<Customer> Get2OrMoreBookCustomers()
        {
            List<Customer> custL = new List<Customer>();
            var custs = this.GetAllCustomers();
            for (int i = 0; i < custs.Count; i++)
            {
                int id = (int)custs[i].Id;
                int count = db.SeatInfoes.Count(me => me.custId == id);
                if (count > 1)
                {
                    custL.Add(db.Customers.Where(a => a.Id == id).FirstOrDefault());
                }
            }
            return custL;
        }

        public List<Customer> GetCustomersName(string name)
        {
            return db.Customers.Where(a => a.Name.Equals(name)).ToList();
        }
        public List<Customer> GetCustomersByID(string id)
        {
            return db.Customers.Where(a => a.Id == int.Parse(id)).ToList();
        }
        public List<Customer> GetCustomersByPhoneNo(string phone)
        {
            return db.Customers.Where(a => a.PhoneNo.Equals(phone)).ToList();
        }
        public List<Customer> GetCustomersByEmail(string em)
        {
            return db.Customers.Where(a => a.Email.Equals(em)).ToList();
        }

        public void DeleteFromBookings(int id)
        {
            var book = db.TicketDetails.Where(a => a.Id == id).FirstOrDefault();
            if (book != null)
            {
                try
                {
                    db.TicketDetails.Remove(book);
                    db.SaveChanges();
                }
                catch (Exception) { }
            }
        }
        public List<TicketDetail> GetBookingDetailsByID(string id)
        {
            return db.TicketDetails.Where(a => a.Id == int.Parse(id)).ToList();
        }
        public List<TicketDetail> GetBookingDetailsByCustID(string id)
        {
            return db.TicketDetails.Where(a => a.custId == int.Parse(id)).ToList();
        }
        public List<TicketDetail> GetBookingDetailsByBusID(string id)
        {
            return db.TicketDetails.Where(a => a.BusId == int.Parse(id)).ToList();
        }

        public List<TicketDetail> GetFronBookings()
        {
            List<TicketDetail> bookings = new List<TicketDetail>();
            
            return bookings;
        }
        public List<TicketDetail> GetMiddleBookings()
        {
            List<TicketDetail> bookings = new List<TicketDetail>();
            return bookings;
        }
        public List<TicketDetail> GetBackBookings()
        {
            List<TicketDetail> bookings = new List<TicketDetail>();
            return bookings;
        }
        public List<TicketDetail> Get2OrMoreResBookings()
        {
            List<TicketDetail> bookings = new List<TicketDetail>();
            return bookings;
        }

        public int TotalNoOCust()
        {
            return db.Customers.Count(a => a.Id > 0);
        }

        public int TotalNoOBus()
        {
            return db.BusInfoes.Count(a => a.id > 0);
        }

        public int TotalNoOBook()
        {
            return db.TicketDetails.Count(a => a.Id > 0);
        }

        public Login GetUserByPass(string pass)
        {
            return db.Logins.Where(a => a.password.Equals(pass)).FirstOrDefault();
        }

        public void ChangePass(Login user, string pass)
        {
            user.password = pass;
            db.SaveChanges();
        }
    }
}
