using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Website.Logic.Application
{
    public class TeamResult: IComparable<TeamResult>
    {
        public TeamResult()
        {
            _name = "";
            _id = 0;
            _played = 0;
            _won = 0;
            _drew = 0;
            _lost = 0;
            _goals = 0;
            _points = 0;
            _goalDifference = 0;
        }
        private string _name;
        private int _id;
        private int _played;
        private int _won;
        private int _drew;
        private int _lost;
        private int _goals;
        private int _points;
        private int _goalDifference;


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
        public int Points
        {
            get
            {
                return _points;

            }
            set
            {
                _points = value;
            }
        }
        public int Lost
        {
            get
            {
                return _lost;

            }
            set
            {
                _lost = value;
            }
        }
        public int Drew
        {
            get
            {
                return _drew;

            }
            set
            {
                _drew = value;
            }
        }
        public int GoalDifference
        {
            get
            {
                return _goalDifference;

            }
            set
            {
                _goalDifference = value;
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

        public int CompareTo(TeamResult other)
        {
            if (this.Points == other.Points) {

                if (this.GoalDifference== other.GoalDifference)
                {
                    return this.Goals > other.Goals ? 1 : -1;
                }
                return this.GoalDifference > other.GoalDifference ? 1 : -1;
            }
            return this.Points > other.Points ? 1 : -1;
        }
    }
}