using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Website.Logic.Application
{
    public class TeamResult
    {
        public TeamResult()
        {
            _played = 0;
            _won = 0;
        }
        private string _name;
        private int _played;
        private int _won;
        private int _goals;
        private int _id;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        public int Goals
        {
            get
            {
                return _goals;
            }
            set
            {
                _goals = value;
            }
        }
        public int Played
        {
            get
            {
                return _played;
            }
            set
            {
                _played = value; 
            }
        }
        public int Won
        {
            get
            {
                return _won;
            }
            set
            {
                _won = value;
            }
        }

    }
}