﻿using System;
using System.Data.Entity;

namespace databaseAzure
{
    public class ZPISRokovnikDatabaseContext : DbContext
    {
        private readonly string databasePath;

        public ZPISRokovnikDatabaseContext(string databasePath)
        {
            this.databasePath = databasePath;
        }


    }
}
