using System;
using System.Collections.Generic;
using System.Net.Mime;
using System.Runtime.InteropServices;
using System.Text;


namespace LostAndFoundDemo
{
    class Menu
    {
        string inputIndex = "";
        int campusIndex, categoryIndex, itemIndex;
        string campus, category, itemName, itemDescription, userName, content;
        List<Campus> Campuslist;
        public void ShowMainMenu()
        {
            Console.WriteLine("_____________________________________");
            Console.WriteLine("|1:录入物品信息   |   2:修改物品信息|");
            Console.WriteLine("|_________________|_________________|");
            Console.WriteLine("|3:删除物品信息   |   4:浏览物品信息|");
            Console.WriteLine("|_________________|_________________|");
            Console.WriteLine("|5:添加评论       |   6:退出        |");
            Console.WriteLine("|_________________|_________________|");
            Console.WriteLine("        请输入您的选择：");
        }
        public int SwitchCampus(string campusname)
        {
            switch(campusname)
            {
                case "文理学部":
                    return 0;
                case "信息学部":
                    return 1;
                case "工学部":
                    return 2;
                case "医学部":
                    return 3;
                default:
                    return -1;
            }
        }
        public int SwitchCategory(string category)
        {
            switch (category)
            {
                case "书籍":
                    return 0;
                case "电子":
                    return 1;
                case "证件":
                    return 2;
                case "日用":
                    return 3;
                case "其他":
                    return 4;
                default:
                    return -1;
            }
        }
        public void Init()
        {
            #region 初始化
            Campuslist = new List<Campus>();
            Campus campus1 = (Campus)ItemFactory.GetItem("Campus");
            Campus campus2 = (Campus)ItemFactory.GetItem("Campus");
            Campus campus3 = (Campus)ItemFactory.GetItem("Campus");
            Campus campus4 = (Campus)ItemFactory.GetItem("Campus");
            campus1.Rename("文理学部");
            campus2.Rename("信息学部");
            campus3.Rename("工学部");
            campus4.Rename("医学部");
            Campuslist.Add(campus1);
            Campuslist.Add(campus2);
            Campuslist.Add(campus3);
            Campuslist.Add(campus4);
            Category category1_1 = (Category)ItemFactory.GetItem("Category");
            Category category1_2 = (Category)ItemFactory.GetItem("Category");
            Category category1_3 = (Category)ItemFactory.GetItem("Category");
            Category category1_4 = (Category)ItemFactory.GetItem("Category");
            Category category1_5 = (Category)ItemFactory.GetItem("Category");
            category1_1.Rename("书籍");
            category1_2.Rename("电子");
            category1_3.Rename("证件");
            category1_4.Rename("日用");
            category1_5.Rename("其他");
            campus1.Add(category1_1);
            campus1.Add(category1_2);
            campus1.Add(category1_3);
            campus1.Add(category1_4);
            campus1.Add(category1_5);
            Category category2_1 = (Category)ItemFactory.GetItem("Category");
            Category category2_2 = (Category)ItemFactory.GetItem("Category");
            Category category2_3 = (Category)ItemFactory.GetItem("Category");
            Category category2_4 = (Category)ItemFactory.GetItem("Category");
            Category category2_5 = (Category)ItemFactory.GetItem("Category");
            category2_1.Rename("书籍");
            category2_2.Rename("电子产品");
            category2_3.Rename("证件");
            category2_4.Rename("日用品");
            category2_5.Rename("其他");
            campus2.Add(category2_1);
            campus2.Add(category2_2);
            campus2.Add(category2_3);
            campus2.Add(category2_4);
            campus2.Add(category2_5);
            Category category3_1 = (Category)ItemFactory.GetItem("Category");
            Category category3_2 = (Category)ItemFactory.GetItem("Category");
            Category category3_3 = (Category)ItemFactory.GetItem("Category");
            Category category3_4 = (Category)ItemFactory.GetItem("Category");
            Category category3_5 = (Category)ItemFactory.GetItem("Category");
            category3_1.Rename("书籍");
            category3_2.Rename("电子产品");
            category3_3.Rename("证件");
            category3_4.Rename("日用品");
            category3_5.Rename("其他");
            campus3.Add(category3_1);
            campus3.Add(category3_2);
            campus3.Add(category3_3);
            campus3.Add(category3_4);
            campus3.Add(category3_5);
            Category category4_1 = (Category)ItemFactory.GetItem("Category");
            Category category4_2 = (Category)ItemFactory.GetItem("Category");
            Category category4_3 = (Category)ItemFactory.GetItem("Category");
            Category category4_4 = (Category)ItemFactory.GetItem("Category");
            Category category4_5 = (Category)ItemFactory.GetItem("Category");
            category4_1.Rename("书籍");
            category4_2.Rename("电子产品");
            category4_3.Rename("证件");
            category4_4.Rename("日用品");
            category4_5.Rename("其他");
            campus4.Add(category4_1);
            campus4.Add(category4_2);
            campus4.Add(category4_3);
            campus4.Add(category4_4);
            campus4.Add(category4_5);
            #endregion
            #region 加入一些项目
            LostAndFoundItem mybook1 = (LostAndFoundItem)ItemFactory.GetItem("LostItem");
            mybook1.Rename("软件架构理论与实践");
            mybook1.EditDescription("白色封皮，封面有名字，本人电话1234567890");
            Campuslist[0].GetChild(0).Add(mybook1);
            #endregion
        }
        public void start()
        {
            LostAndFoundItem newItem = (LostAndFoundItem)ItemFactory.GetItem("LostItem");
            while (inputIndex != "6")
            {
                ShowMainMenu();
                inputIndex = Console.ReadLine();
                switch (inputIndex)
                {
                    case "1":
                        Console.WriteLine("请输入校区名：（文理学部/工学部/信息学部/医学部）");
                        campus = Console.ReadLine();
                        campusIndex = SwitchCampus(campus);
                        if (campusIndex == -1)
                            break;
                        Console.WriteLine("请输入物品类型：（书籍/电子/日用/证件/其他）");
                        category = Console.ReadLine();
                        categoryIndex = SwitchCategory(category);
                        if (categoryIndex == -1)
                            break;
                        Console.WriteLine("请输入物品名称：");
                        itemName = Console.ReadLine();
                        Console.WriteLine("请输入物品描述：");
                        itemDescription = Console.ReadLine();
                        newItem.Rename(itemName);
                        newItem.EditDescription(itemDescription);
                        Campuslist[campusIndex].GetChild(categoryIndex).Add(newItem);
                        break;
                    case "2":
                        Console.WriteLine("请输入校区名：（文理学部/工学部/信息学部/医学部）");
                        campus = Console.ReadLine();
                        campusIndex =SwitchCampus(campus);
                        if (campusIndex == -1)
                            break;
                        Console.WriteLine("请输入物品类型：（书籍/电子/日用/证件/其他）");
                        category = Console.ReadLine();
                        categoryIndex = SwitchCategory(category);
                        if (categoryIndex == -1)
                            break;
                        Campuslist[campusIndex].GetChild(categoryIndex).DisPlay();
                        Console.WriteLine("请输入你要修改的物品序号：（从1开始由上至下）");
                        itemIndex = Convert.ToInt32(Console.ReadLine()) - 1;
                        Console.WriteLine("请输入物品名称：");
                        itemName = Console.ReadLine();
                        Console.WriteLine("请输入物品描述：");
                        itemDescription = Console.ReadLine();
                        newItem = (LostAndFoundItem)Campuslist[campusIndex].GetChild(categoryIndex).GetChild(itemIndex);
                        newItem.Rename(itemName);
                        newItem.EditDescription(itemDescription);
                        Campuslist[campusIndex].GetChild(categoryIndex).Remove(Campuslist[campusIndex].GetChild(categoryIndex).GetChild(itemIndex));
                        Campuslist[campusIndex].GetChild(categoryIndex).Add(newItem);
                        break;
                    case "3":
                        Console.WriteLine("请输入校区名：（文理学部/工学部/信息学部/医学部）");
                        campus = Console.ReadLine();
                        campusIndex = SwitchCampus(campus);
                        if (campusIndex == -1)
                            break;
                        Console.WriteLine("请输入物品类型：（书籍/电子/日用/证件/其他）");
                        category = Console.ReadLine();
                        categoryIndex = SwitchCategory(category);
                        if (categoryIndex == -1)
                            break;
                        Campuslist[campusIndex].GetChild(categoryIndex).DisPlay();
                        Console.WriteLine("请输入你要删除的物品序号：（从1开始由上至下）");
                        itemIndex = 1 + Convert.ToInt32(Console.ReadLine());
                        Campuslist[campusIndex].GetChild(categoryIndex).Remove(Campuslist[campusIndex].GetChild(categoryIndex).GetChild(itemIndex));
                        break;
                    case "4":
                        Console.WriteLine("请输入校区名：（文理学部/工学部/信息学部/医学部）");
                        campus = Console.ReadLine();
                        campusIndex = SwitchCampus(campus);
                        if (campusIndex == -1)
                            break;
                        Campuslist[campusIndex].DisPlay();
                        Console.WriteLine("请输入物品类型：（书籍/电子/日用/证件/其他）");
                        category = Console.ReadLine();
                        categoryIndex = SwitchCategory(category);
                        if (categoryIndex == -1)
                            break;
                        Campuslist[campusIndex].GetChild(categoryIndex).DisPlay();
                        break;
                    case "5":
                        Console.WriteLine("请输入校区名：（文理学部/工学部/信息学部/医学部）");
                        campus = Console.ReadLine();
                        campusIndex = SwitchCampus(campus);
                        if (campusIndex == -1)
                            break;
                        Console.WriteLine("请输入物品类型：（书籍/电子/日用/证件/其他）");
                        category = Console.ReadLine();
                        categoryIndex = SwitchCategory(category);
                        if (categoryIndex == -1)
                            break;
                        Campuslist[campusIndex].GetChild(categoryIndex).DisPlay();
                        Console.WriteLine("请输入你要修改的物品序号：（从1开始由上至下）");
                        itemIndex = Convert.ToInt32(Console.ReadLine()) - 1;
                        Console.WriteLine("请输入你的用户名：");
                        userName = Console.ReadLine();
                        Console.WriteLine("请输入你的评论：");
                        content = Console.ReadLine();
                        Account account = new Account();
                        account.Rename(userName);
                        Comment comment = (Comment)ItemFactory.GetItem("Comment");
                        comment.SetName(userName);
                        comment.setContent(content);
                        newItem.AddObserver(account);
                        newItem.Update();
                        Campuslist[campusIndex].GetChild(categoryIndex).GetChild(itemIndex).Add(comment);
                        break;
                }
            }
        }
    }
}
