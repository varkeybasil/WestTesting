﻿using System;
using System.Collections.Generic;
using SQLite;

namespace West.Models
{
    public class Expense
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string Name { get; set; }

        public double Amount { get; set; }


        public static int InsertExpense(Expense expense)
        {
            using (SQLite.SQLiteConnection conn = new SQLiteConnection(App.DatabasePath))
            {
                conn.CreateTable<Expense>();
                return conn.Insert(expense);
            }
        }

        public static List<Expense> GetExpenses()
        {
            using (SQLiteConnection conn = new SQLiteConnection(App.DatabasePath))
            {
                conn.CreateTable<Expense>();
                return conn.Table<Expense>().ToList();
            }
        }


    }
}
