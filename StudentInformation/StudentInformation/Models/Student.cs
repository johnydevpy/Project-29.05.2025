﻿namespace StudentInformation.Models
{
    public class Student
    {

        public int ID {  get; set; }
        public string Name { get; set; }
        public string Email {  get; set; }
        public string Phone { get; set; }

        public bool Subscribed {  get; set; }
    }
}
