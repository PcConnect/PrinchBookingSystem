﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrinchBook
{
    public class Resource
    {
        private string resourceId;
        private string resourceType;
        private long libraryId;
        private string funct;
        private bool adult;
        private bool available;
        private string name;

        public Resource(string resourceId,string resourceType,long libraryId,string funct,bool adult,bool available,string name)
        {
            this.resourceId = resourceId;
            this.resourceType = resourceType;
            this.libraryId = libraryId;
            this.funct = funct;
            this.adult = adult;
            this.available = available;
            this.name = name;
        }

        public Resource()
        {
            // TODO: Complete member initialization
        }

        public string ResourceID{
            get { return resourceId; }
            set { resourceId = value; }
            
        }


        public long LibraryID
        {
            get { return libraryId; }
            set { libraryId = value; }
        }
        public string Funct
        {
            get { return funct; }
            set { funct = value; }
        }
        public bool Available
        {
            get { return available; }
            set { available = value; }
        }
        public bool Adult{
            get { return adult; }
            set { adult = value; }
        }
        public string ResourceType {
            get { return resourceType; }
            set { resourceType = value; }
        }
        public string Name {
            get { return name; }
            set { name = value; }
        }
    }
}
