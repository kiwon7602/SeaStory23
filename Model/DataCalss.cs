using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaStory.Model
{
    public class DataCalss
    {
        //회원정보 데이터 클래스
        public class User
        {
            public string Name { get; set; }
            public string PhoneNumber { get; set; }
            public string Time { get; set; }
            public string UsedTime { get; set; }
            public string LoginType { get; set; }
            public bool UserType { get; set; }
        }
        //비회원 정보 데이터 클래스
        public class NonMember
        {
            public string CardNumber { get; set; }
            public int RemainingHours { get; set; }
            public bool IsActive { get; set; }
        }
        //음식  정보 데이터 클래스
        public class Food
        {
            public string FoodName { get; set; }
            public string FoodCode { get; set; }
            public int FoodPrice { get; set; }
            public string ImageURL { get; set; }
        }
        //요금제 정보 데이터 클래스
        public class SubscriptionTable
        {
            public string SubscriptionKey;
            public string SubscriptionName;
            public int SubscriptionAmount;
            public int SubscriptionHours;

        }
        //주문  정보 데이터 클래스
        public class OrderTable
        {
            public string FoodCode;
            public object OrderTime;
            public string OrderSeat;
        }

        public class Seat
        {
            public int SeatNumber;
            public string UserID;
            public string UsageTime;
        }


    }
}
