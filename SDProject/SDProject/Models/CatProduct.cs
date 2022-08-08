using Microsoft.EntityFrameworkCore;
using SDProject.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SDProject.Models
{
    public class CatProduct
    {



        public IEnumerable<Category> AllCategoryViewModel { set; get; }
        public Product OneProductViewModel { set; get; }
        public SliderImages ImagesViewModel { set; get; }
        public IEnumerable<Product> AllProductViewModel { set; get; }
        public Contact contact { set; get; }

        public IEnumerable<User> userList { set; get; }
        public User user { set; get; }
        public IEnumerable<ApplicationUsercs> userLists { set; get; }
        public ApplicationUsercs users { set; get; }
        public IEnumerable<Order> Order { set; get; }
        public IEnumerable<OrderDetails> OrderDetails { set; get; }
        public Try Try{get;set;}
        public IEnumerable<Try> Allreview { get; set; }
        public ReviewTest ReviewTest { get; set; }
        public IEnumerable<ReviewTest> Allreviewtest { get; set; }
        public IEnumerable<Order2> Order2 { set; get; }
        public IEnumerable<OrderDetails2> OrderDetails2 { set; get; }
        public X.PagedList.IPagedList<Product> Products { set; get; }
        public IEnumerable<About> About { set; get; }


    }
}
