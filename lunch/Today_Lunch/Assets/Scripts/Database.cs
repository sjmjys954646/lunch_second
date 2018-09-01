using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Database : MonoBehaviour
{
    public List<Info> Shop = new List<Info>();

    //1.몇번 2.식당이름 3.음식종류 4.위치 5.가격 6.배달음식
    public class Info
    {
        public int Num, Area;
        public string Storename, Foodkind, Pos, Price;
        public bool Deliever;

        public Info(int a, string b, string c, string d, string e, bool f, int g)
        {
            Num = a;
            Storename = b;
            Foodkind = c;
            Pos = d;
            Price = e;
            Deliever = f;
            Area = g;
        }
    }

    private void Start()
    {
        WriteInfo();
    }
   
    public void WriteInfo()
    {
        Shop.Add(new Info(1,"스피드반점", "중식", "쪽문", "하", false, 1));
        Shop.Add(new Info(2, "밥스", "퓨전", "쪽문", "하", false, 1));
        Shop.Add(new Info(3, "털보하우스", "퓨전", "쪽문", "하", false, 1));
        Shop.Add(new Info(4, "용봉골", "한식", "쪽문", "하", false, 1));
        Shop.Add(new Info(5, "얌얌", "양식", "쪽문", "중", false, 1));
        Shop.Add(new Info(6, "석쇠쌈밥", "한식", "쪽문", "하", false, 1));
        Shop.Add(new Info(7, "부리또", "양식", "쪽문", "하", false, 1));
        Shop.Add(new Info(8, "사랑방하우스", "한식", "쪽문", "하", false, 1));
        Shop.Add(new Info(9, "나들목국밥", "한식", "쪽문", "중", false, 8));
        Shop.Add(new Info(10, "파리에다녀온치킨", "치킨", "쪽문", "상", false, 1));
        Shop.Add(new Info(11, "피가로", "양식", "쪽문", "상", false, 2));
        Shop.Add(new Info(12, "봉추찜닭", "한식", "쪽문", "상", false, 2));
        Shop.Add(new Info(13, "예원", "일식", "쪽문", "중/상", false, 2));
        Shop.Add(new Info(14, "화석시대", "고깃집", "쪽문", "상", false, 3));
        Shop.Add(new Info(15, "신쭈꾸미", "한식", "쪽문", "중/상", false, 3));
        Shop.Add(new Info(16, "락희식당", "고깃집", "쪽문", "상", false, 3));
        Shop.Add(new Info(17, "한솥", "한식", "쪽문", "하", false, 2));
        Shop.Add(new Info(18, "산쪼메", "일식", "쪽문", "중", false, 2));
        Shop.Add(new Info(19, "오꾸닭", "치킨", "쪽문", "상", false, 2));
        Shop.Add(new Info(20, "최고당", "양식", "쪽문", "중", false, 2));
        Shop.Add(new Info(21, "발발이추억", "한식", "쪽문", "상", false, 3));
        Shop.Add(new Info(22, "마녀치킨", "치킨", "쪽문", "상", false, 3));
        Shop.Add(new Info(23, "69식당", "고깃집", "쪽문", "상", false, 3));
        Shop.Add(new Info(24, "새마을식당", "고깃집", "쪽문", "중/상", false, 2));
        Shop.Add(new Info(25, "통큰돈까스", "양식", "쪽문", "중", false, 2));
        Shop.Add(new Info(26, "포베이", "양식", "쪽문", "중", false, 2));
        Shop.Add(new Info(27, "고수닭갈비", "한식", "쪽문", "상", false, 2));
        Shop.Add(new Info(28, "밥풀", "한식", "쪽문", "중", false, 3));
        Shop.Add(new Info(29, "참돈", "고깃집", "쪽문", "상", false, 3));
        Shop.Add(new Info(30, "더진국", "한식", "쪽문", "중", false , 3));
        Shop.Add(new Info(31, "마늘보쌈", "고깃집", "쪽문", "상", false, 3));
        Shop.Add(new Info(32, "서래", "고깃집", "쪽문", "상", false, 2));
        Shop.Add(new Info(33, "놀부보쌈", "한식", "쪽문", "상", false, 2));
        Shop.Add(new Info(34, "샤브향", "한식", "쪽문", "상", false, 2));
        Shop.Add(new Info(35, "오라구", "양식", "쪽문", "상", false, 2));
        Shop.Add(new Info(36, "노랑통닭", "치킨", "쪽문", "상", false, 3));
        Shop.Add(new Info(37, "치킨퐁", "치킨", "쪽문", "상", false, 2));
        Shop.Add(new Info(38, "만계치킨", "치킨", "쪽문", "상", false, 3));
        Shop.Add(new Info(39, "BHC", "치킨", "쪽문", "상", false, 3));
        Shop.Add(new Info(40, "난타5000", "양식", "후문", "중", false, 5));
        Shop.Add(new Info(41, "미스터초밥", "일식", "후문", "상", false, 5));
        Shop.Add(new Info(42, "놀부부대찌개", "한식", "후문", "상", false, 5));
        Shop.Add(new Info(43, "간42", "한식", "후문", "하", false, 5));
        Shop.Add(new Info(44, "남다른감자탕", "한식", "후문", "상", false, 4));
        Shop.Add(new Info(45, "혼끼", "일식", "후문", "중", false, 5));
        Shop.Add(new Info(46, "오이시", "일식", "후문", "중", false, 5));
        Shop.Add(new Info(47, "신가네 매운 떡볶이", "분식", "후문", "하/중", false, 5));
        Shop.Add(new Info(48, "쪼아저씨네 파스타", "양식", "후문", "상", false, 5));
        Shop.Add(new Info(49, "틈새라면", "분식", "후문", "하", false, 5));
        Shop.Add(new Info(50, "명량핫도그", "후식", "후문", "하", false, 5));
        Shop.Add(new Info(51, "반미바게트", "후식", "후문", "하/중", false, 5));
        Shop.Add(new Info(52, "깡패버거", "분식", "후문", "중", false, 5));
        Shop.Add(new Info(53, "홍대돈부리", "일식", "후문", "중", false, 5));
        Shop.Add(new Info(54, "1988고기뷔폐", "고깃집", "후문", "상", false, 5));
        Shop.Add(new Info(55, "마카나이", "일식", "후문", "상", false, 4));
        Shop.Add(new Info(56, "라스타", "분식", "후문", "중", false, 4));
        Shop.Add(new Info(57, "카츠앤 소바", "일식", "후문", "중/상", false, 4));
        Shop.Add(new Info(58, "부대통령", "한식", "후문", "하", false, 4));
        Shop.Add(new Info(59, "도쿄스테이크", "양식", "후문", "상", false, 4));
        Shop.Add(new Info(60, "얼쑤", "한식", "후문", "중", false, 4));
        Shop.Add(new Info(61, "차이나궁", "중식", "후문", "중", false, 4));
        Shop.Add(new Info(62, "로니로티", "양식", "후문", "상", false, 4));
        Shop.Add(new Info(63, "한마음 정육식당", "고깃집", "후문", "상", false, 4));
        Shop.Add(new Info(64, "조봉순 상무국밥", "한식", "후문", "중", false, 4));
        Shop.Add(new Info(65, "수내닭꼬치", "후식", "후문", "하", false, 4));
        Shop.Add(new Info(66, "바론떡볶이", "분식", "후문", "중", false, 4));
        Shop.Add(new Info(67, "쭉심", "한식", "후문", "상", false, 4));
        Shop.Add(new Info(68, "담소 소사골 국밥", "한식", "후문", "중", false, 4));
        Shop.Add(new Info(69, "교촌치킨", "치킨", "후문", "상", false, 4));
        Shop.Add(new Info(70, "청춘대패", "고깃집", "후문", "상", false, 4));
    }

}


