using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IS413_Temple_Signup_ZS.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder application)
        {
            tourGroupContext context = application.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<tourGroupContext>();

            //If database has pending migrations then move those migrations into the database
            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            //If database does not have any books in it then populate it with the following data
            if (!context.timeSlots.Any())
            {
                context.timeSlots.AddRange(
                    
                    //Day 1
                    new timeSlot
                    {
                        //TimeSlot 1, day 1
                        scheduleInfo = new DateTime(2021, 03, 17, 8, 0, 0)
                    },

                    new timeSlot
                    {
                        //TimeSlot 2, day 1
                        scheduleInfo = new DateTime(2021, 03, 17, 9, 0, 0)
                    },

                    new timeSlot
                    {
                        //TimeSlot 3, day 1
                        scheduleInfo = new DateTime(2021, 03, 17, 10, 0, 0)
                    },

                    new timeSlot
                    {
                        //TimeSlot 4, day 1
                        scheduleInfo = new DateTime(2021, 03, 17, 11, 0, 0)
                    },

                    new timeSlot
                    {
                        //TimeSlot 5, day 1
                        scheduleInfo = new DateTime(2021, 03, 17, 12, 0, 0)
                    },

                    new timeSlot
                    {
                        //TimeSlot 6, day 1
                        scheduleInfo = new DateTime(2021, 03, 17, 13, 0, 0)
                    },

                    new timeSlot
                    {
                        //TimeSlot 7, day 1
                        scheduleInfo = new DateTime(2021, 03, 17, 14, 0, 0)
                    },

                    new timeSlot
                    {
                        //TimeSlot 8, day 1
                        scheduleInfo = new DateTime(2021, 03, 17, 15, 0, 0)
                    },

                    new timeSlot
                    {
                        //TimeSlot 9, day 1
                        scheduleInfo = new DateTime(2021, 03, 17, 16, 0, 0)
                    },

                    new timeSlot
                    {
                        //TimeSlot 10, day 1
                        scheduleInfo = new DateTime(2021, 03, 17, 17, 0, 0)
                    },

                    new timeSlot
                    {
                        //TimeSlot 11, day 1
                        scheduleInfo = new DateTime(2021, 03, 17, 18, 0, 0)
                    },

                    new timeSlot
                    {
                        //TimeSlot 12, day 1
                        scheduleInfo = new DateTime(2021, 03, 17, 19, 0, 0)
                    },

                    new timeSlot
                    {
                        //TimeSlot 13, day 1
                        scheduleInfo = new DateTime(2021, 03, 17, 20, 0, 0)
                    },



                    //Day 2
                    new timeSlot
                    {
                        //TimeSlot 1, day 2
                        scheduleInfo = new DateTime(2021, 03, 18, 8, 0, 0)
                    },

                    new timeSlot
                    {
                        //TimeSlot 2, day 2
                        scheduleInfo = new DateTime(2021, 03, 18, 9, 0, 0)
                    },

                    new timeSlot
                    {
                        //TimeSlot 3, day 2
                        scheduleInfo = new DateTime(2021, 03, 18, 10, 0, 0)
                    },

                    new timeSlot
                    {
                        //TimeSlot 4, day 2
                        scheduleInfo = new DateTime(2021, 03, 18, 11, 0, 0)
                    },

                    new timeSlot
                    {
                        //TimeSlot 5, day 2
                        scheduleInfo = new DateTime(2021, 03, 18, 12, 0, 0)
                    },

                    new timeSlot
                    {
                        //TimeSlot 6, day 2
                        scheduleInfo = new DateTime(2021, 03, 18, 13, 0, 0)
                    },

                    new timeSlot
                    {
                        //TimeSlot 7, day 2
                        scheduleInfo = new DateTime(2021, 03, 18, 14, 0, 0)
                    },

                    new timeSlot
                    {
                        //TimeSlot 8, day 2
                        scheduleInfo = new DateTime(2021, 03, 18, 15, 0, 0)
                    },

                    new timeSlot
                    {
                        //TimeSlot 9, day 2
                        scheduleInfo = new DateTime(2021, 03, 18, 16, 0, 0)
                    },

                    new timeSlot
                    {
                        //TimeSlot 10, day 2
                        scheduleInfo = new DateTime(2021, 03, 18, 17, 0, 0)
                    },

                    new timeSlot
                    {
                        //TimeSlot 11, day 2
                        scheduleInfo = new DateTime(2021, 03, 18, 18, 0, 0)
                    },

                    new timeSlot
                    {
                        //TimeSlot 12, day 2
                        scheduleInfo = new DateTime(2021, 03, 18, 19, 0, 0)
                    },

                    new timeSlot
                    {
                        //TimeSlot 13, day 2
                        scheduleInfo = new DateTime(2021, 03, 18, 20, 0, 0)
                    },




                    //Day 3
                    new timeSlot
                    {
                        //TimeSlot 1, day 3
                        scheduleInfo = new DateTime(2021, 03, 19, 8, 0, 0)
                    },

                    new timeSlot
                    {
                        //TimeSlot 2, day 3
                        scheduleInfo = new DateTime(2021, 03, 19, 9, 0, 0)
                    },

                    new timeSlot
                    {
                        //TimeSlot 3, day 3
                        scheduleInfo = new DateTime(2021, 03, 19, 10, 0, 0)
                    },

                    new timeSlot
                    {
                        //TimeSlot 4, day 3
                        scheduleInfo = new DateTime(2021, 03, 19, 11, 0, 0)
                    },

                    new timeSlot
                    {
                        //TimeSlot 5, day 3
                        scheduleInfo = new DateTime(2021, 03, 19, 12, 0, 0)
                    },

                    new timeSlot
                    {
                        //TimeSlot 6, day 3
                        scheduleInfo = new DateTime(2021, 03, 19, 13, 0, 0)
                    },

                    new timeSlot
                    {
                        //TimeSlot 7, day 3
                        scheduleInfo = new DateTime(2021, 03, 19, 14, 0, 0)
                    },

                    new timeSlot
                    {
                        //TimeSlot 8, day 3
                        scheduleInfo = new DateTime(2021, 03, 19, 15, 0, 0)
                    },

                    new timeSlot
                    {
                        //TimeSlot 9, day 3
                        scheduleInfo = new DateTime(2021, 03, 19, 16, 0, 0)
                    },

                    new timeSlot
                    {
                        //TimeSlot 10, day 3
                        scheduleInfo = new DateTime(2021, 03, 19, 17, 0, 0)
                    },

                    new timeSlot
                    {
                        //TimeSlot 11, day 3
                        scheduleInfo = new DateTime(2021, 03, 19, 18, 0, 0)
                    },

                    new timeSlot
                    {
                        //TimeSlot 12, day 3
                        scheduleInfo = new DateTime(2021, 03, 19, 19, 0, 0)
                    },

                    new timeSlot
                    {
                        //TimeSlot 13, day 3
                        scheduleInfo = new DateTime(2021, 03, 19, 20, 0, 0)
                    },



                    //Day 4
                    new timeSlot
                    {
                        //TimeSlot 1, day 4
                        scheduleInfo = new DateTime(2021, 03, 20, 8, 0, 0)
                    },

                    new timeSlot
                    {
                        //TimeSlot 2, day 4
                        scheduleInfo = new DateTime(2021, 03, 20, 9, 0, 0)
                    },

                    new timeSlot
                    {
                        //TimeSlot 3, day 4
                        scheduleInfo = new DateTime(2021, 03, 20, 10, 0, 0)
                    },

                    new timeSlot
                    {
                        //TimeSlot 4, day 4
                        scheduleInfo = new DateTime(2021, 03, 20, 11, 0, 0)
                    },

                    new timeSlot
                    {
                        //TimeSlot 5, day 4
                        scheduleInfo = new DateTime(2021, 03, 20, 12, 0, 0)
                    },

                    new timeSlot
                    {
                        //TimeSlot 6, day 4
                        scheduleInfo = new DateTime(2021, 03, 20, 13, 0, 0)
                    },

                    new timeSlot
                    {
                        //TimeSlot 7, day 4
                        scheduleInfo = new DateTime(2021, 03, 20, 14, 0, 0)
                    },

                    new timeSlot
                    {
                        //TimeSlot 8, day 4
                        scheduleInfo = new DateTime(2021, 03, 20, 15, 0, 0)
                    },

                    new timeSlot
                    {
                        //TimeSlot 9, day 4
                        scheduleInfo = new DateTime(2021, 03, 20, 16, 0, 0)
                    },

                    new timeSlot
                    {
                        //TimeSlot 10, day 4
                        scheduleInfo = new DateTime(2021, 03, 20, 17, 0, 0)
                    },

                    new timeSlot
                    {
                        //TimeSlot 11, day 4
                        scheduleInfo = new DateTime(2021, 03, 20, 18, 0, 0)
                    },

                    new timeSlot
                    {
                        //TimeSlot 12, day 4
                        scheduleInfo = new DateTime(2021, 03, 20, 19, 0, 0)
                    },

                    new timeSlot
                    {
                        //TimeSlot 13, day 4
                        scheduleInfo = new DateTime(2021, 03, 20, 20, 0, 0)
                    },


                    //Day 5
                    new timeSlot
                    {
                        //TimeSlot 1, day 5
                        scheduleInfo = new DateTime(2021, 03, 21, 8, 0, 0)
                    },

                    new timeSlot
                    {
                        //TimeSlot 2, day 5
                        scheduleInfo = new DateTime(2021, 03, 21, 9, 0, 0)
                    },

                    new timeSlot
                    {
                        //TimeSlot 3, day 5
                        scheduleInfo = new DateTime(2021, 03, 21, 10, 0, 0)
                    },

                    new timeSlot
                    {
                        //TimeSlot 4, day 5
                        scheduleInfo = new DateTime(2021, 03, 21, 11, 0, 0)
                    },

                    new timeSlot
                    {
                        //TimeSlot 5, day 5
                        scheduleInfo = new DateTime(2021, 03, 21, 12, 0, 0)
                    },

                    new timeSlot
                    {
                        //TimeSlot 6, day 5
                        scheduleInfo = new DateTime(2021, 03, 21, 13, 0, 0)
                    },

                    new timeSlot
                    {
                        //TimeSlot 7, day 5
                        scheduleInfo = new DateTime(2021, 03, 21, 14, 0, 0)
                    },

                    new timeSlot
                    {
                        //TimeSlot 8, day 5
                        scheduleInfo = new DateTime(2021, 03, 21, 15, 0, 0)
                    },

                    new timeSlot
                    {
                        //TimeSlot 9, day 5
                        scheduleInfo = new DateTime(2021, 03, 21, 16, 0, 0)
                    },

                    new timeSlot
                    {
                        //TimeSlot 10, day 5
                        scheduleInfo = new DateTime(2021, 03, 21, 17, 0, 0)
                    },

                    new timeSlot
                    {
                        //TimeSlot 11, day 5
                        scheduleInfo = new DateTime(2021, 03, 21, 18, 0, 0)
                    },

                    new timeSlot
                    {
                        //TimeSlot 12, day 5
                        scheduleInfo = new DateTime(2021, 03, 21, 19, 0, 0)
                    },

                    new timeSlot
                    {
                        //TimeSlot 13, day 5
                        scheduleInfo = new DateTime(2021, 03, 21, 20, 0, 0)
                    },


                    //Day 6
                    new timeSlot
                    {
                        //TimeSlot 1, day 6
                        scheduleInfo = new DateTime(2021, 03, 22, 8, 0, 0)
                    },

                    new timeSlot
                    {
                        //TimeSlot 2, day 6
                        scheduleInfo = new DateTime(2021, 03, 22, 9, 0, 0)
                    },

                    new timeSlot
                    {
                        //TimeSlot 3, day 6
                        scheduleInfo = new DateTime(2021, 03, 22, 10, 0, 0)
                    },

                    new timeSlot
                    {
                        //TimeSlot 4, day 6
                        scheduleInfo = new DateTime(2021, 03, 22, 11, 0, 0)
                    },

                    new timeSlot
                    {
                        //TimeSlot 5, day 6
                        scheduleInfo = new DateTime(2021, 03, 22, 12, 0, 0)
                    },

                    new timeSlot
                    {
                        //TimeSlot 6, day 6
                        scheduleInfo = new DateTime(2021, 03, 22, 13, 0, 0)
                    },

                    new timeSlot
                    {
                        //TimeSlot 7, day 6
                        scheduleInfo = new DateTime(2021, 03, 22, 14, 0, 0)
                    },

                    new timeSlot
                    {
                        //TimeSlot 8, day 6
                        scheduleInfo = new DateTime(2021, 03, 22, 15, 0, 0)
                    },

                    new timeSlot
                    {
                        //TimeSlot 9, day 6
                        scheduleInfo = new DateTime(2021, 03, 22, 16, 0, 0)
                    },

                    new timeSlot
                    {
                        //TimeSlot 10, day 6
                        scheduleInfo = new DateTime(2021, 03, 22, 17, 0, 0)
                    },

                    new timeSlot
                    {
                        //TimeSlot 11, day 6
                        scheduleInfo = new DateTime(2021, 03, 22, 18, 0, 0)
                    },

                    new timeSlot
                    {
                        //TimeSlot 12, day 6
                        scheduleInfo = new DateTime(2021, 03, 22, 19, 0, 0)
                    },

                    new timeSlot
                    {
                        //TimeSlot 13, day 6
                        scheduleInfo = new DateTime(2021, 03, 22, 20, 0, 0)
                    },



                    //Day 7
                    new timeSlot
                    {
                        //TimeSlot 1, day 7
                        scheduleInfo = new DateTime(2021, 03, 23, 8, 0, 0)
                    },

                    new timeSlot
                    {
                        //TimeSlot 2, day 7
                        scheduleInfo = new DateTime(2021, 03, 23, 9, 0, 0)
                    },

                    new timeSlot
                    {
                        //TimeSlot 3, day 7
                        scheduleInfo = new DateTime(2021, 03, 23, 10, 0, 0)
                    },

                    new timeSlot
                    {
                        //TimeSlot 4, day 7
                        scheduleInfo = new DateTime(2021, 03, 23, 11, 0, 0)
                    },

                    new timeSlot
                    {
                        //TimeSlot 5, day 7
                        scheduleInfo = new DateTime(2021, 03, 23, 12, 0, 0)
                    },

                    new timeSlot
                    {
                        //TimeSlot 6, day 7
                        scheduleInfo = new DateTime(2021, 03, 23, 13, 0, 0)
                    },

                    new timeSlot
                    {
                        //TimeSlot 7, day 7
                        scheduleInfo = new DateTime(2021, 03, 23, 14, 0, 0)
                    },

                    new timeSlot
                    {
                        //TimeSlot 8, day 7
                        scheduleInfo = new DateTime(2021, 03, 23, 15, 0, 0)
                    },

                    new timeSlot
                    {
                        //TimeSlot 9, day 7
                        scheduleInfo = new DateTime(2021, 03, 23, 16, 0, 0)
                    },

                    new timeSlot
                    {
                        //TimeSlot 10, day 7
                        scheduleInfo = new DateTime(2021, 03, 23, 17, 0, 0)
                    },

                    new timeSlot
                    {
                        //TimeSlot 11, day 7
                        scheduleInfo = new DateTime(2021, 03, 23, 18, 0, 0)
                    },

                    new timeSlot
                    {
                        //TimeSlot 12, day 7
                        scheduleInfo = new DateTime(2021, 03, 23, 19, 0, 0)
                    },

                    new timeSlot
                    {
                        //TimeSlot 13, day 7
                        scheduleInfo = new DateTime(2021, 03, 23, 20, 0, 0)
                    }

                );

                //Save changes
                context.SaveChanges();
            }
        }
    }
}
