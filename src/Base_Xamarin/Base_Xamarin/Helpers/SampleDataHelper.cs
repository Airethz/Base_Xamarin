using Base_Xamarin.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Base_Xamarin.Helpers
{
    public class SampleDataHelper
    {
        public List<Language> GetLanguages()
        {
            List<Language> result = new List<Language>();

            #region 資料建立
            result.Add(new Language()
            {
                Rank = 1,
                Name = "Python",
                Ratings = "13.44%"
            });
            result.Add(new Language()
            {
                Rank = 2,
                Name = "C",
                Ratings = "13.13%"
            });
            result.Add(new Language()
            {
                Rank = 3,
                Name = "Java",
                Ratings = "11.59%"
            });
            result.Add(new Language()
            {
                Rank = 4,
                Name = "C++",
                Ratings = "10.00%"
            });
            result.Add(new Language()
            {
                Rank = 5,
                Name = "C#",
                Ratings = "5.65%"
            });
            result.Add(new Language()
            {
                Rank = 6,
                Name = "Visual Basic",
                Ratings = "4.97%"
            });
            result.Add(new Language()
            {
                Rank = 7,
                Name = "JavaScript",
                Ratings = "1.78%"
            });
            result.Add(new Language()
            {
                Rank = 8,
                Name = "Assembly language",
                Ratings = "1.65%"
            });
            result.Add(new Language()
            {
                Rank = 9,
                Name = "SQL",
                Ratings = "1.64%"
            });
            result.Add(new Language()
            {
                Rank = 10,
                Name = "Swift",
                Ratings = "1.27%"
            });
            #endregion

            return result;
        }
    }
}
