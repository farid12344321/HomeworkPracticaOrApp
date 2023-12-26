



// See https://aka.ms/new-console-template for more information

#region task1
//Verilmiş 3 ədəddən hansının ən böyük olduğunu tapan proqram

//Console.WriteLine("1 - ededi daxil edin");
//string num1Str = Console.ReadLine();
//int num1 = Convert.ToInt32(num1Str);

//Console.WriteLine("2 - ededi daxil edin");
//string num2Str = Console.ReadLine();
//int num2 = Convert.ToInt32(num2Str);

//Console.WriteLine("3 - ededi daxil edin");
//string num3Str = Console.ReadLine();
//int num3 = Convert.ToInt32(num3Str);

//int large = 0;

//if (num1 > num2)
//{
//    if (num1 > num3)
//    {
//        large = num1;
//    }
//    else
//    {
//        large = num3;
//    }
//}
//else if (num2 > num3)
//{
//    large = num2;
//}
//else
//{
//    large = num3;
//}



//Console.WriteLine("cavab = " +large);

#endregion


#region task2
//Verilmiş yazının içində A hərfinin olub olmadığını tapan proqram


//Console.WriteLine("Yazi elave edin");
//string text1 = Console.ReadLine();

//Console.WriteLine("Herifi elave edin");
//string text2Str = Console.ReadLine();
//char text2 = Convert.ToChar(text2Str);

//bool check = false;

//for (int i = 0; i < text1.Length; i++)
//{
//	if (text1[i] == text2)
//	{
//		check = true; 
//		break;
//	}
//}

//if (check == true)
//{
//    Console.WriteLine("VAR");
//}
//else
//{
//    Console.WriteLine("YOXDUR");
//}


#endregion


#region task3
//Verilmiş yazıda neçə A hərfinin olduğunu tapan proqram

//Console.WriteLine("Yazi elave edin");
//string text1 = Console.ReadLine();

//Console.WriteLine("Herifi elave edin");
//string text2Str = Console.ReadLine();
//char text2 = Convert.ToChar(text2Str);

//int count = 0;

//for (int i = 0; i < text1.Length; i++)
//{
//    if (text1[i] == text2)
//    {
//        count++;
//    }
//}

//Console.WriteLine(count);

#endregion


#region task4
//Verilmiş müsbət cüt ədədi kradtarına yüksəldən proqram. Daxil edilən ədə musbət və cüt olmadıqca yenidən daxil edilməlidir



//int num;
//do
//{
//    Console.WriteLine("Ededi daxil edin");
//    string numStr = Console.ReadLine();
//    num = Convert.ToInt32(numStr);
//} while (num <=0 || num%2!=0);

//num *= num;
//Console.WriteLine("cavab = " +num);


#endregion


#region task5
//Verilmiş 5 uzunluqlu ədədlər siyahısındaki ədədlərin cəmini tapan proqram

//Console.WriteLine("Uzunluqu daxil edin");
//string numsStr = Console.ReadLine();
//int nums = Convert.ToInt32(numsStr);

//int[] datas = new int[nums];
//int sum = 0;

//for (int i = 0; i < datas.Length; i++)
//{
//    Console.WriteLine($"eded yaz.{i + 1} ");
//    string numStr = Console.ReadLine();
//    int num = Convert.ToInt32(numStr);

//    sum += num;
//}
//Console.WriteLine(sum);


#endregion


#region task6
//Verilmiş təhsil növü dəyərinə əsasən o təhsilin saatını göstərən proqram.Əgər verilmiş dəyər "programming"dirsə console-da 400 saat, "design"dırsa 250 saat,
//"system"dirsə 200 saat, heç biri deyilsə "təhsil novu yanlisdir" yazılmalıdır console-da.

//bool check = true;
//do
//{
//    Console.WriteLine("Tehsil novunu daxil edin:");
//    string education = Console.ReadLine();
//    check = true;

//    switch (education)
//    {
//        case "programming":
//            Console.WriteLine("400 saat");
//            break;
//        case "design":
//            Console.WriteLine("250 saat");
//            break;
//        case "system":
//            Console.WriteLine("200 saat");
//            break;
//        default:
//            check = false;
//            Console.WriteLine("Yanlisdir");
//            break;
//    }
//} while (!check);
#endregion

//==============================================================================================

#region task1
//Verilmiş yazıdan içində boşluqlar olmayan yeni bir yazı düzəltmək 

//Console.WriteLine("Yazi daxil edin");
//string textStr = Console.ReadLine();

//string str = "";

//for (int i = 0; i < textStr.Length; i++)
//{
//	if (textStr[i] != ' ')
//	{
//		str += textStr[i];
//	}
//}
//Console.WriteLine(str);
#endregion


#region tesk2
//Verilmiş ədədlər siyahısındaki verilmiş n ədədinin yerləşdiyi indexi tapan proqram


//int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 89 };

//int item = 5;
//int index = -1;

//for (int i = 0; i < numbers.Length; i++)
//{
//    if (numbers[i] == item)
//    {
//        index = i;
//        break;

//    }
//}
//Console.WriteLine(index);


#endregion


#region task3
//Verilmiş yazılar siyahısında verilmiş hərfdən neçə ədəd olduğunu tapan proqram

//Console.WriteLine("Sayi elave edin");
//string dataStr = Console.ReadLine();
//int data = Convert.ToInt32(dataStr);

//string[] datas = new string[data];

//for (int i = 0; i < datas.Length; i++)
//{
//    Console.WriteLine($"Yazilari elave edin -{i+1}");
//    datas[i] = Console.ReadLine();
//}

//Console.WriteLine("Herifi daxil edin");
//string letStr = Console.ReadLine();

//char let = Convert.ToChar(letStr);

//int count = 0;
//for (int i = 0;i < datas.Length; i++)
//{
//    string str = datas[i];

//    for (int j = 0; j < str.Length; j++)
//    {
//        if (str[j] == let)
//        {
//            count++;
//        }
//    }

//}
//Console.WriteLine(count);

#endregion


#region task4
//Verilmiş yazının əvvəlindəki boşluqlar silinmiş bir string düzəldən proqram (Misalçün verilmiş yazı
//"   salam necesen?   "-dirsə yeni düzələcək string "salam necəsən?   " olmalıdır.
//Console.WriteLine("Yazini eleva edin");
//string textStr = Console.ReadLine();

//string str = "";

//int Index = 0;
//for (int i = 0; i < textStr.Length; i++)
//{
//    if (textStr[i] != ' ')
//    {
//        Index = i;
//        break;
//    }
//}

//for (int i = Index; i < textStr.Length; i++)
//{
//    str += textStr[i];
//}
//Console.WriteLine(str);
#endregion


#region task5
//Verilmiş 2 ədəd üzərində verilmiş simvola uyğun əməliyyat edən proqram.
//Simvol +,-,* və ya / olmalıdır, əks halda simvolu yenidən daxil edilməsi istənilməlidir.
//(Misaçün simvol * olarsa verilmiş 2 ədəd vurulacaq və nəticəsi göstəriləcək)


//Console.WriteLine("1 ededi daxil edin");
//string num1str = Console.ReadLine();
//int num1 = Convert.ToInt32(num1str);

//Console.WriteLine("2 ededi daxil edin");
//string num2str = Console.ReadLine();
//int num2 = Convert.ToInt32(num2str);


//bool check;
//int result = 0;
//do
//{
//	Console.WriteLine("operator daxil edin");
//	string operation = Console.ReadLine();
//	check = true;


//	switch (operation)
//	{
//		case "+":
//			result = num1 + num2;
//			break;
//		case "-":
//			result = num1 - num2;
//			break;
//		case "*":
//			result = num1 * num2;
//			break;
//		case "/":
//			result = num1 / num2;
//			break;
//		default:
//			check = false;
//			Console.WriteLine("Operator novu yanlisdir");
//			break;
//	}
//} while (!check);


//Console.WriteLine(result);
#endregion



//==============================================================================================


#region calcAPP
//bool check = true;
//do
//{
//    int result = 0;

//    Console.WriteLine("1 ededi daxil edin");
//    string num1Str = Console.ReadLine();
//    int num1 = Convert.ToInt32(num1Str);


//    Console.WriteLine("2 ededi daxil edin");
//    string num2Str = Console.ReadLine();
//    int num2 = Convert.ToInt32(num2Str);

//    Console.WriteLine("1. Topla");
//    Console.WriteLine("2. Cixma");
//    Console.WriteLine("3. Vurma");
//    Console.WriteLine("4. Bolme");

//    check = true;
//    string opt = Console.ReadLine();

//    switch (opt)
//    {
//        case "1":
//            result = num1 + num2;
//            Console.WriteLine($"Cavab  = " + result);
//            break;
//        case "2":
//            result = num1 - num2;
//            Console.WriteLine($"Cavab  = " + result);
//            break;
//        case "3":
//            result = num1 * num2;
//            Console.WriteLine($"Cavab  = " + result);
//            break;
//        case "4":
//            result = num1 / num2;
//            Console.WriteLine($"Cavab  = " + result);
//            break;
//        default:
//            Console.WriteLine("yanlis emeliyyat");
//            break;
//    }

//    Console.WriteLine("Davam edirsiz (he ,yox ) :");

//} while (Console.ReadLine() == "he");
//Console.WriteLine("proqram bitdi");

#endregion





