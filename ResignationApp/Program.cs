
Console.WriteLine("Hello, World!");
ResignationApp.Resignation resignation =new ResignationApp.Resignation ();
ResignationApp.IT iT = new ResignationApp.IT(resignation);
ResignationApp.Finance finance = new ResignationApp.Finance(resignation);
resignation.DoResignation();