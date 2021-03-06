﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App8.Entity
{
    class Member
    {
        [Required]
        private string _firstName;
        [DataType(DataType.Text)]
        private string _lastName;
        private string _avatar;
        [Phone]
        private string _phone;
        [EmailAddress]
        private string _address;
        private string _introduction;
        private int _gender = 1;
        private string _birthday;
        [EmailAddress]
        private string _email;
        private string _password;

        public string firstName { get => _firstName; set => _firstName = value; }
        public string lastName { get => _lastName; set => _lastName = value; }
        public string avatar { get => _avatar; set => _avatar = value; }
        public string phone { get => _phone; set => _phone = value; }
        public string address { get => _address; set => _address = value; }
        public string introduction { get => _introduction; set => _introduction = value; }
        public int gender { get => _gender; set => _gender = value; }
        public string birthday { get => _birthday; set => _birthday = value; }
        public string email { get => _email; set => _email = value; }
        public string password { get => _password; set => _password = value; }
    }
}
