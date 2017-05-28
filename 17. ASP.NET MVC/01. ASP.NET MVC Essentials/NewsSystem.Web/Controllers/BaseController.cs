using NewsSystem.Web.Models;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace NewsSystem.Web.Controllers
{
    public class BaseController : Controller
    {
        private IList<New> news = new List<New>
        {
            new New() {Id = 1, CreatedOn = DateTime.Now.AddDays(-6), Creator = "Pesho", Title = "Marco Rubio: the Republican - and Cuban - Obama", Content = "Republican presidential candidate  Marco Rubio arrives to address supporters at a caucus night party at the Marriott hotel in Des Moines The 44-year-old candidate for the GOP came third in the Iowa caucus leading many to now ask: does Jeb Bush's mentee have a shot at the candidacy?" , Rating = 18 },
            new New() {Id = 2, CreatedOn = DateTime.Now.AddDays(-5), Creator = "Gosho", Title = "Pope sends olive branch to China amid hopes of reconciliation", Content = "The Vatican is seeking greater control in selecting bishops in a process which is vetted by China’s Communist leaders" , Rating = 63 },
            new New() {Id = 3, CreatedOn = DateTime.Now.AddDays(-4), Creator = "Mara", Title = "Zimbabwe's prosecutor-general arrested 'for failing to take up Mugabe dairy bombing plot'", Content = "Johannes Tomana, the former attorney-general, is accused of obstructing justice over handling of a 'highly suspect' case against two men accused of plotting to bomb a dairy run by Grace Mugabe" , Rating = 54 },
            new New() {Id = 4, CreatedOn = DateTime.Now.AddDays(-3), Creator = "Pena", Title = "Burning man 'sucked out of plane' over Mogadishu after explosion on board", Content = "An explosion – thought to have been a bomb – ripped a hole in the side of a plane, with reports that the charred body of a man fell to earth" , Rating = 23 },
            new New() {Id = 5, CreatedOn = DateTime.Now.AddDays(-2), Creator = "Gora", Title = "Japan says it will shoot down North Korean rocket if it threatens its territory", Content = "Pyongyang claims vehicle will put observation satellite into orbit, but analysts say launch is a test of a long-range ballistic missile" , Rating = 71 },
            new New() {Id = 6, CreatedOn = DateTime.Now.AddDays(-1), Creator = "Kaka dora", Title = "Elephant that killed British tourist performed at Thai safari camp tainted by cruelty allegations", Content = "Animal welfare campaigners launch fresh bid to ban elephant rides as ‘world’s cruellest wildlife tourist attraction’ after Gareth Crowe trampled and gored" , Rating = 94 },
            new New() {Id = 7, CreatedOn = DateTime.Now, Creator = "Petra", Title = "After Iowa, Bernie Sanders could become the next Democrat presidential nominee", Content = "Hillary Clinton's campaign team said it 'strongly' believed she had won after 95 per cent of Iowa precincts had reported" , Rating = 86 },
            new New() {Id = 8, CreatedOn = DateTime.Now.AddDays(1), Creator = "Kiro", Title = "Torres, Di Maria, Van Wolfswinkel - why breaking transfer record is a terrible idea", Content = "Stoke and Bournemouth have both made record purchases in the winter window - they should be careful what they wish for..." , Rating = 3, Category = "football" },
            new New() {Id = 9, CreatedOn = DateTime.Now.AddDays(2), Creator = "Kuna", Title = "Goal of the season - our writers' nominations", Content = "After Jamie Vardy's wondergoal against Liverpool, our writers name the best goal they have seen so far this season" , Rating = 2, Category = "football" },
            new New() {Id = 10, CreatedOn = DateTime.Now.AddDays(3), Creator = "Maca", Title = "Why United would be mad to let Carrick leave", Content = "Data: United win more, score more and aren't as boring when Carrick plays - so why wouldn't they extend his contract?" , Rating = 1, Category = "football" }
        };

        private IList<User> users = new List<User>
        {
            new User() { Id = 1, Username = "Pesho" },
            new User() { Id = 2, Username = "Gosho" },
            new User() { Id = 3, Username = "Tosho" },
            new User() { Id = 4, Username = "Mara" },
            new User() { Id = 5, Username = "Pepa" }
        };

        public IList<New> News
        {
            get
            {
                return this.news;
            }
        }

        public IList<User> Users
        {
            get
            {
                return this.users;
            }
        }
    }
}