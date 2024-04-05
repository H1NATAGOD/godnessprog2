namespace GarageConsoleApp;

/// <summary>
 /// Класс Program
 /// здесь описываем логику приложения
 /// вызываем нужные методы, пишем обработчики и т.д.
 /// </summary>
 public class Program
 {
  public static void Main(string[] args)
  {

   Console.WriteLine($"Панель выбора Beta \n1 - Получите список водителей \n2 - Добавьте нового водителя \n3 - Посмотрите категории прав у определённого водителя \n4 - Добавьте новую категорую \n5 - Добавьте новый тип автомобиля \n6 - Получите данные о типах автомобилей \n7 - Добавьте новое транспортное средство \n8 - Посмотрите данные о транспортных средствах \n9 - Добавьте новый маршрут \n10 - Доббавьте данные о поездке \n11 - просмотрите имеющиеся маршруты \nQ - Выход ");
   /// Создаем переменную для цикла
   string bang = Console.ReadLine();
   
   /// Цикл будет работать Бесконечно, пока не ввести нужный символ
   while (bang != "Q")
   {
    switch (bang)
    {
     
     case "1":
      // Вызов метода на получение списка водителей
      DatabaseRequests.GetDriverQuery();
      Console.WriteLine();
      break;
     
     case "2":
      // Добавдление нового водителя в БД
      DatabaseRequests.AddDriverQuery(Console.ReadLine(), Console.ReadLine(), DateTime.Parse(Console.ReadLine()));
      break;
     
     case "3":
      // Вызов метода для получения данных о категории определённого водителя
      int id = int.Parse(Console.ReadLine());
      DatabaseRequests.GetDriverRightsCategoryQuery(id);
      Console.WriteLine();
      break;
     
     case "4":
      // Добавление новой категории
      DatabaseRequests.AddRightsCategoryQuery(Console.ReadLine());
      break;
      
     case "5":
      // Добавление нового типа автомобиля в БД
      DatabaseRequests.AddTypeCarQuery(Console.ReadLine());
      break;
     
     case "6":
      // Вызов метода для получения данных о типах автомобилей
      DatabaseRequests.GetTypeCarQuery();
      break;
     
     
     case "7" :
      // Добавление нового автомобиля
      // Сделанно на бек мек, работать будет если Console.ReadLine в саму AddCars, а так лень(

      string name = Console.ReadLine();
      string state_number = Console.ReadLine();
      int number_passengers = Int32.Parse(Console.ReadLine());
      int id_type_car = Int32.Parse(Console.ReadLine());
      DatabaseRequests.AddCars(name,state_number,number_passengers, id_type_car);
      break;
     
     case "8":
      // Вызов метода для получения данных о машинах
     DatabaseRequests.GetCarQuery();
      break;
     
     case "9" :
      // Добавление нового маршрута
      DatabaseRequests.AddItinerary(Console.ReadLine());
      break;
     
     case "10":
      // Добавление данных о поездке
      // Тут не лень было делать
      DatabaseRequests.AddRoute(Int32.Parse(Console.ReadLine()), Int32.Parse(Console.ReadLine()),Int32.Parse(Console.ReadLine()),Int32.Parse(Console.ReadLine())  );  
      break;
     
     case "11" :
      // Вызов метода для получения данных Маршруте 
      DatabaseRequests.GetItineraryQuery();
      break;
     
     case "12":
      //Добавляет категории водителю
      //Я только в конце вспомнил
      DatabaseRequests.AddDriverRightsCategoryQuery(int.Parse(Console.ReadLine()),Int32.Parse(Console.ReadLine()));
      break;
    
     default:
      //Логичный и дефолтный дефаут, пиши что хочешь и при ошибке типо должен вводить данное сообщение
      Console.WriteLine($"Ты лох!!!!!");
      break;
     
     
     
     
    }
    // Моя гениальная разработка, разработанная всеми программистами. Хочешь продолжить изменять бдэху,да пожалуйста
    bang = Console.ReadLine();
   }
  }
 }
