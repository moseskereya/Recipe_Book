namespace Moses.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Moses.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<Moses.Data.MosesContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Moses.Data.MosesContext";
        }

        protected override void Seed(Moses.Data.MosesContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            context.Customers.AddOrUpdate( i => i.Id,
                  new Customer
                  {
                      Name = "Moses Lazaro",
                      City = "Arusha",
                      Email = "lazaromoses77@gmail.com"
                  },
                   new Customer
                   {
                       Name = "ScottCate",
                       City = "West Palm Beach, Florida US",
                       Email = "me@ScottCate.com"
                   },
                    new Customer
                    {
                        Name = "John Doe",
                        City = "Berlin, German",
                        Email = "Doe22@gmail.com"
                    }
                  );
                        context.Categories.AddOrUpdate(
                        new Category
                        {
                            Name = "Cokies",
                            CategoryId = 1,
                            Description =" Welcome to our Restaurant for you will be served with our proffesional cooking team here."
                            

                        },
                        new Category
                        {
                            Name = "Cakes",
                            CategoryId = 2,
                            Description = "We make a stunning looking and Sweet cakes you would love"
                        },
                        new Category
                        {
                            Name = "Cupcakes",
                            CategoryId = 2,
                            Description = "The Best CupCakes of the Week"
                        }

                        );

            context.Pies.AddOrUpdate( i => i.CategotyId,
                  new Pie
                  {
                      CategotyId = 1,
                      Name = "Peanut Butter Cookies",
                      Price = 67.45M,
                      ImgUrl = "https://images.pexels.com/photos/251865/pexels-photo-251865.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500",
                      ShortDescription = "There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don't look even slightly believable. If you are going to use a passage of Lorem Ipsum",
                      LongDescription = "A favorite for all the peanut butter lovers, these cookies are made with hand rolled dough that is often flattened with a fork to achieve that familiar waffle pattern. This technique was first introduced in the 1933 edition of ,'Pillsbury',s Balanced Recipes', and also helps to distinguish this cookie for those with peanut allergies."
                  },
                  new Pie
                  {
                      CategotyId = 1,
                      Name = "Gingersnaps",
                      Price = 50.56M,

                      ImgUrl = "https://images.pexels.com/photos/6195/bread-food-baking-homemade.jpg?auto=compress&cs=tinysrgb&dpr=1&w=500",
                      ShortDescription = "There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don't look even slightly believable. If you are going to use a passage of Lorem Ipsum",
                      LongDescription = "Also known as ginger nuts or ginger biscuits, these spicy treats are popular all around the world. Powdered ginger, cinnamon, molasses, and nutmeg make this popular holiday cookie the perfect blend of sweet and spicy."
                  },
                  new Pie
                  {
                      CategotyId = 1,
                      Name = "Whoopie Pies",
                      Price = 100.45M,
                      ImgUrl = "https://images.pexels.com/photos/251865/pexels-photo-251865.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500",
                      ShortDescription = "There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don't look even slightly believable. If you are going to use a passage of Lorem Ipsum",
                      LongDescription = "A favorite for all the peanut butter lovers, these cookies are made with hand rolled dough that is often flattened with a fork to achieve that familiar waffle pattern. This technique was first introduced in the 1933 edition of ,'Pillsbury',s Balanced Recipes', and also helps to distinguish this cookie for those with peanut allergies."
                  },
                  new Pie
                  {
                     CategotyId = 1,
                      Name = "Molasses Cookies",
                      Price = 30.44M,
                      ImgUrl = "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fstatic.onecms.io%2Fwp-content%2Fuploads%2Fsites%2F43%2F2019%2F08%2F5741363.jpg",
                      ShortDescription = "There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don't look even slightly believable. If you are going to use a passage of Lorem Ipsum",
                      LongDescription = "An offshoot of the popular holiday gingerbread cookies, molasses cookies are made with just as much ginger. Sometimes molasses is the sole sweetener in these cookies, and other times it's made with a mixture of sugar and molasses. They can come in either a soft, cake form or a chewier crinkle form (perfect for gifting)."
                  },
                  new Pie
                  {
                      CategotyId = 1,
                      Name = "Tassies",
                      Price = 78.67M,
                      ImgUrl = "https://images.pexels.com/photos/251865/pexels-photo-251865.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500",
                      ShortDescription = "There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don't look even slightly believable. If you are going to use a passage of Lorem Ipsum, you need to be sure there isn't anything embarrassing hidden in the middle of text",
                      LongDescription = "Less cookie than mini pie, tassies are a Southern delicacy. They are made by molding dough into small muffin cups which are then filled with an egg filling. These adorable mini pies will stand out on any holiday dessert spread."
                  },
                  // two
                  new Pie
                  {
                      CategotyId = 2,
                      Name = "Flourless Cake",
                      Price = 89.99M,
                      ImgUrl = "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/cheese-cake-1577124381.jpg?crop=1.00xw:0.760xh;0,0.133xh&resize=980:*",
                      ShortDescription = "All the Lorem Ipsum generators on the Internet tend to repeat predefined chunks as necessary, making this the first true generator on the Internet. It uses a dictionary ",
                      LongDescription = "This category includes both baked (think cheese cake or flourless chocolate) or unbaked (like mousse or unbaked cheesecakes) varieties. Typically very rich because of the high fat content, these cakes may or may not have a bottom crumb crust."
                  },
              new Pie
              {
                  CategotyId = 2,
                  Name = "Devil’s Food Cake",
                  Price = 100.35M,
                  ImgUrl = "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/devils-food-cake-1577124539.jpg?crop=1.00xw:0.911xh;0,0.0658xh&resize=980:*",
                  ShortDescription = "All the Lorem Ipsum generators on the Internet tend to repeat predefined chunks as necessary, making this the first true generator on the Internet. It uses a dictionary ",
                  LongDescription = "This cake is made 'devilish' , by the addition of chocolate in the form of cocoa powder. Extra baking soda causes the crumb to have more air bubbles, giving it a light and airy texture. This rich cake is frosted with either chocolate frosting or buttercream."
              },
              new Pie
              {
                 CategotyId = 2,
                  Name = "Opera Cake",
                  Price = 300.45M,
                  ImgUrl = "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/opera-cake-royalty-free-image-1578350233.jpg?crop=1xw:1xh;center,top&resize=980:*",
                  ShortDescription = "All the Lorem Ipsum generators on the Internet tend to repeat predefined chunks as necessary, making this the first true generator on the Internet. It uses a dictionary ",
                  LongDescription = "The history of this type of cake is a bit muddled. One thing we do know, however, is that its thin layers of coffee-soaked almond cake are sandwiched between an espresso-flavored buttercream, a bittersweet chocolate ganache, and topped off with a second rich chocolate ganache. Light but rich, this pastry is a real showstopper"
              },
              new Pie
              {
                  CategotyId = 2,

                  Name = "Yellow Butter Cake",
                  Price = 200.56M,
                  ImgUrl = "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/3-layer-yellow-butter-cake-1574436790.jpg?crop=1.00xw:0.834xh;0,0.110xh&resize=980:*",
                  ShortDescription = "All the Lorem Ipsum generators on the Internet tend to repeat predefined chunks as necessary, making this the first true generator on the Internet. It uses a dictionary ",
                  LongDescription = "Many a kid's birthday party is celebrated with a sheet-cake version of this dessert that's topped with billows of chocolate frosting and rainbow sprinkles. Yellow butter cakes often involve creaming the butter and sugar together (in modern times, this is done with an electric mixer) then adding the dry and wet ingredients, but there are also “dump” versions where all of the ingredients are thrown into a bowl and simply mixed together."
              },
              new Pie
              {
                  CategotyId = 2,

                  Name = "Pound Cake",
                  Price = 250.65M,
                  ImgUrl = "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/chocolate-matcha-swirl-pound-cake-1574437002.jpg?crop=1xw:1xh;center,top&resize=980:*",
                  ShortDescription = "All the Lorem Ipsum generators on the Internet tend to repeat predefined chunks as necessary, making this the first true generator on the Internet. It uses a dictionary ",
                  LongDescription = "Named because it's made with a pound of each of the main ingredients (flour, butter, and sugar), this cake doesn’t rise much while baking, and the texture is very dense. Our version boasts matcha and cocoa powder, but classic recipes have nothing but vanilla extract to flavor it. Bake up one of these beauties in a loaf or Bundt pan"
              },
              // three

              new Pie
              {
                  CategotyId = 3,
                  Name = "Peanut Butter Fudge Coffee Ice Cream Cupcakes",
                  Price = 284.02M,
                  ImgUrl = "https://www.berries.com/blog/wp-content/uploads/2016/01/15-how-sweet.jpg",
                  ShortDescription = "These decadent delicacies boast a frozen surprise inside- a coffee ice cream center. Keep a batch handy in the freezer to combat caffeine and sugar cravings- a dessert double whammy. Thanks to How Sweet It Is for sharing photo and recipe for these Peanut Butter Fudge Coffee Ice Cream Cupcakes",
                  LongDescription = "These decadent delicacies boast a frozen surprise inside- a coffee ice cream center. Keep a batch handy in the freezer to combat caffeine and sugar cravings- a dessert double whammy. Thanks to How Sweet It Is for sharing photo and recipe for these Peanut Butter Fudge Coffee Ice Cream Cupcakes, The struggle is real. Eliminate that decision and get the best of both worlds with these decadent marbled cupcakes. It’s just so much more delicious when everyone works together. Thanks to Sally’s Baking Addiction for sharing photo and recipe for these Ultimate Marble Cupcakes."
              },
              new Pie
              {
                  CategotyId = 3,

                  Name = "Churro Cupcake",
                  Price = 400.67M,
                  ImgUrl = "https://www.berries.com/blog/wp-content/uploads/2016/01/25-churro.jpg",
                  ShortDescription = "The friendship of donuts and cupcakes is cemented in this vanilla bestie topped with a churro and dusted in a healthy coating of cinnamon sugar. Que rico! Thanks to The Domestic Rebel for sharing photo and recipe for these Churro Cupcakes.",
                  LongDescription = "These decadent delicacies boast a frozen surprise inside- a coffee ice cream center. Keep a batch handy in the freezer to combat caffeine and sugar cravings- a dessert double whammy. Thanks to How Sweet It Is for sharing photo and recipe for these Peanut Butter Fudge Coffee Ice Cream Cupcakes, The struggle is real. Eliminate that decision and get the best of both worlds with these decadent marbled cupcakes. It’s just so much more delicious when everyone works together. Thanks to Sally’s Baking Addiction for sharing photo and recipe for these Ultimate Marble Cupcakes."
              },

          new Pie
          {
              CategotyId = 3,

              Name = "Lime Coconut Cupcakes",
              Price = 145.54M,
              ImgUrl = "https://www.berries.com/blog/wp-content/uploads/2016/01/19-house-of-yumm.jpg",
              ShortDescription = "That catchy song had it all wrong. You mix de lime and de coconut into a mouth-watering cupcake and eat it all up! Thanks to House of Yumm for sharing photo and recipe for these Lime Coconut Cupcakes.",
              LongDescription = "These decadent delicacies boast a frozen surprise inside- a coffee ice cream center. Keep a batch handy in the freezer to combat caffeine and sugar cravings- a dessert double whammy. Thanks to How Sweet It Is for sharing photo and recipe for these Peanut Butter Fudge Coffee Ice Cream Cupcakes, The struggle is real. Eliminate that decision and get the best of both worlds with these decadent marbled cupcakes. It’s just so much more delicious when everyone works together. Thanks to Sally’s Baking Addiction for sharing photo and recipe for these Ultimate Marble Cupcakes."
          },

          new Pie
          {
              CategotyId = 3,

              Name = "Blackberry Coconut Cupcakes",
              Price = 120.00M,
              ImgUrl = "https://www.berries.com/blog/wp-content/uploads/2016/01/21-baking-a-moment.jpg",
              ShortDescription = "The tropical flavor of coconut combined with the tart sweetness of blackberry delivers a one-two punch that will leave your taste buds in a knockout. Thanks to Baking a Moment for sharing photo and recipe for these Blackberry Coconut Cupcakes.",
              LongDescription = "These decadent delicacies boast a frozen surprise inside- a coffee ice cream center. Keep a batch handy in the freezer to combat caffeine and sugar cravings- a dessert double whammy. Thanks to How Sweet It Is for sharing photo and recipe for these Peanut Butter Fudge Coffee Ice Cream Cupcakes, The struggle is real. Eliminate that decision and get the best of both worlds with these decadent marbled cupcakes. It’s just so much more delicious when everyone works together. Thanks to Sally’s Baking Addiction for sharing photo and recipe for these Ultimate Marble Cupcakes."

          },

          new Pie
          {
              CategotyId = 3,

              Name = "Piña Colada Cupcakes",
              Price = 330.44M,
              ImgUrl = "https://www.berries.com/blog/wp-content/uploads/2016/01/18-pina-colada1.jpg",
              ShortDescription = "If you like piña coladas…..well, no doubt you’re going to love these cupcakes. Channel the best of a tiki bar, sans hangover, with these tantalizing tropical-tinged treats. Thanks to Glorious Treats for sharing photo and recipe for these Piña Colada Cupcakes.",
              LongDescription = "These decadent delicacies boast a frozen surprise inside- a coffee ice cream center. Keep a batch handy in the freezer to combat caffeine and sugar cravings- a dessert double whammy. Thanks to How Sweet It Is for sharing photo and recipe for these Peanut Butter Fudge Coffee Ice Cream Cupcakes, The struggle is real. Eliminate that decision and get the best of both worlds with these decadent marbled cupcakes. It’s just so much more delicious when everyone works together. Thanks to Sally’s Baking Addiction for sharing photo and recipe for these Ultimate Marble Cupcakes."
          },

          new Pie
          {
              CategotyId = 3,

              Name = "Easter Cupcakes with Bunny Inside",
              Price = 300.00M,
              ImgUrl = "https://www.berries.com/blog/wp-content/uploads/2016/01/31-easter-bunny.jpg",
              ShortDescription = "With a frosting that tastes just like the beloved batter, this is the perfect recipe for anyone unable to resist the lure of licking the bowl when making cookies. Thanks to Cupcake Project for sharing the recipe for these Easter Cupcakes With a Surprise Bunny Inside, photo by J. Pollack Photography.",
              LongDescription = "These decadent delicacies boast a frozen surprise inside- a coffee ice cream center. Keep a batch handy in the freezer to combat caffeine and sugar cravings- a dessert double whammy. Thanks to How Sweet It Is for sharing photo and recipe for these Peanut Butter Fudge Coffee Ice Cream Cupcakes, The struggle is real. Eliminate that decision and get the best of both worlds with these decadent marbled cupcakes. It’s just so much more delicious when everyone works together. Thanks to Sally’s Baking Addiction for sharing photo and recipe for these Ultimate Marble Cupcakes."
          },
          new Pie
          {
              CategotyId = 3,

              Price = 200.03M,
              Name = "Paleo Maple Bacon Cupcakes",
              ImgUrl = "https://www.berries.com/blog/wp-content/uploads/2016/01/32-food-faith.jpg",
              ShortDescription = "This cupcake brings to mind all the comforts of a decadent weekend breakfast full of sticky bacon and syurp laden pancakes. Give your diet a high-five and indulge in one of these paleo-friendly treats. Thanks to Food Faith Fitness for sharing photo and recipe for these paleo Maple Bacon Cupcakes With Bacon Buttercream.",
              LongDescription = "These decadent delicacies boast a frozen surprise inside- a coffee ice cream center. Keep a batch handy in the freezer to combat caffeine and sugar cravings- a dessert double whammy. Thanks to How Sweet It Is for sharing photo and recipe for these Peanut Butter Fudge Coffee Ice Cream Cupcakes, The struggle is real. Eliminate that decision and get the best of both worlds with these decadent marbled cupcakes. It’s just so much more delicious when everyone works together. Thanks to Sally’s Baking Addiction for sharing photo and recipe for these Ultimate Marble Cupcakes."
          },
          new Pie
          {
              CategotyId = 3,

              Name = "Chocolate Stout Cupcakes",
              Price = 180.94M,
              ImgUrl = "https://www.berries.com/blog/wp-content/uploads/2016/01/41-broma-stout.jpg",
              ShortDescription = "Sea salt and a dark stout such as Guinness add complexity and depth to these super rich double chocolate cupcakes. Thanks to Broma Bakery for sharing photo and recipe for these Chocolate Stout Cupcakes.",
              LongDescription = "These decadent delicacies boast a frozen surprise inside- a coffee ice cream center. Keep a batch handy in the freezer to combat caffeine and sugar cravings- a dessert double whammy. Thanks to How Sweet It Is for sharing photo and recipe for these Peanut Butter Fudge Coffee Ice Cream Cupcakes, The struggle is real. Eliminate that decision and get the best of both worlds with these decadent marbled cupcakes. It’s just so much more delicious when everyone works together. Thanks to Sally’s Baking Addiction for sharing photo and recipe for these Ultimate Marble Cupcakes."
          },
          new Pie
          {
              CategotyId = 3,

              Name = "Chocolate Soft Serve Cupcakes",
              ImgUrl = "https://www.berries.com/blog/wp-content/uploads/2016/01/42-sugar-hit.jpg",
              Price = 299.99M,
              ShortDescription = "These sweet treats are creatively disguised as mini ice cream cones, making for an adorable addition to any birthday party or summer festivity. Thanks to The Sugar Hit for sharing photo and recipe for these Chocolate Soft Serve Cupcakes.",
              LongDescription = "These decadent delicacies boast a frozen surprise inside- a coffee ice cream center. Keep a batch handy in the freezer to combat caffeine and sugar cravings- a dessert double whammy. Thanks to How Sweet It Is for sharing photo and recipe for these Peanut Butter Fudge Coffee Ice Cream Cupcakes, The struggle is real. Eliminate that decision and get the best of both worlds with these decadent marbled cupcakes. It’s just so much more delicious when everyone works together. Thanks to Sally’s Baking Addiction for sharing photo and recipe for these Ultimate Marble Cupcakes."
          },
              new Pie
              {
                  CategotyId = 3,

                  Name = " Ice Cream Sundae Cupcakes",
                  ImgUrl = "https://www.berries.com/blog/wp-content/uploads/2016/01/45-frugal-mom.jpg",
                  Price = 100.90M,
                  ShortDescription = "It eats like a cupcake, but looks like a creamy bowl of ice cream! Witha mound of sugary buttercream and a fresh coating of sprinkles, this cupcake is having the best kind of identity crisis! Thanks to Frugal Momeh! for sharing photo and recipe for these Ice Cream Sundae Cupcakes.",
                  LongDescription = "These decadent delicacies boast a frozen surprise inside- a coffee ice cream center. Keep a batch handy in the freezer to combat caffeine and sugar cravings- a dessert double whammy. Thanks to How Sweet It Is for sharing photo and recipe for these Peanut Butter Fudge Coffee Ice Cream Cupcakes, The struggle is real. Eliminate that decision and get the best of both worlds with these decadent marbled cupcakes. It’s just so much more delicious when everyone works together. Thanks to Sally’s Baking Addiction for sharing photo and recipe for these Ultimate Marble Cupcakes."
              },
          new Pie
          {
              CategotyId = 3,
              Name = "Chocolate Drizzled Peppermint Cupcakes",
              Price = 200.65M,
              ImgUrl = "https://www.berries.com/blog/wp-content/uploads/2016/01/47-oh-lady-cake.jpg",
              ShortDescription = "When days turn colder and twinkling holiday lights are aglow, these cupcakes are the perfect way to usher in some holiday spirit. Season’s eatings! Thanks to Oh, Lady Cakes for sharing photo and recipe for these Chocolate Drizzled Peppermint Cupcakes.",
              LongDescription = "These decadent delicacies boast a frozen surprise inside- a coffee ice cream center. Keep a batch handy in the freezer to combat caffeine and sugar cravings- a dessert double whammy. Thanks to How Sweet It Is for sharing photo and recipe for these Peanut Butter Fudge Coffee Ice Cream Cupcakes, The struggle is real. Eliminate that decision and get the best of both worlds with these decadent marbled cupcakes. It’s just so much more delicious when everyone works together. Thanks to Sally’s Baking Addiction for sharing photo and recipe for these Ultimate Marble Cupcakes."
          }

          );

        }
    }
}
