using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Employee
    {
        private String id;
        private String name;
        private DateTime birthday;
        private bool gender;
        private String address;
        private String email;
        private String tel;
        private int role;

        public DTO_Employee() { }

        public DTO_Employee(String id) {
            this.Id = id;
        }

        public DTO_Employee(String id, String name, DateTime birthday, bool gender, String address, String email, String tel, int role) {
            this.Id = id;
            this.Name = name;
            this.Birthday = birthday;
            this.Gender = gender;
            this.Address = address;
            this.Email = email;
            this.Tel = tel;
            this.Role = role;
        }

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public DateTime Birthday { get => birthday; set => birthday = value; }
        public bool Gender { get => gender; set => gender = value; }
        public string Address { get => address; set => address = value; }
        public string Email { get => email; set => email = value; }
        public string Tel { get => tel; set => tel = value; }
        public int Role { get => role; set => role = value; }
    }
}
