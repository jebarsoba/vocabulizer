﻿using SQLite;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace DAL
{
    public class WordRepository
    {
        SQLiteConnection db = DependencyService.Get<ISQLiteConnection>().GetConnection();

        public void Add(Word word)
        {
            db.CreateTable<Word>();

            db.Insert(word);
        }

        public IList<Word> GetAll()
        {
            //TODO: create table at app startup.
            db.CreateTable<Word>();

            return db.Table<Word>().ToList();
        }
    }
}