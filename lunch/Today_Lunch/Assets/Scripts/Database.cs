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
        public string Storename, Foodkind, Pos, Price, Explanation;
        public bool Deliever;

        public Info(int a, string b, string c, string d, string e, bool f, int g, string h)
        {
            Num = a;
            Storename = b;
            Foodkind = c;
            Pos = d;
            Price = e;
            Deliever = f;
            Area = g;
            Explanation = h;
        }
    }

    private void Start()
    {
        WriteInfo();
    }
   
    public void WriteInfo()
    {
        Shop.Add(new Info(1,"스피드반점", "중식", "쪽문", "하", false, 1, "중국음식집"));
        Shop.Add(new Info(2, "밥스", "퓨전", "쪽문", "하", false, 1, "밥과 관련된 음식"));
        Shop.Add(new Info(3, "털보하우스", "퓨전", "쪽문", "하", false, 1, "여러 가지 음식 및 분식집"));
        Shop.Add(new Info(4, "용봉골", "한식", "쪽문", "하", false, 1, "양념된 고기집"));
        Shop.Add(new Info(5, "얌얌", "양식", "쪽문", "중", false, 1, "오므라이스 전문점"));
        Shop.Add(new Info(6, "석쇠쌈밥", "한식", "쪽문", "하", false, 1, "쌈밥 외의 찌개류"));
        Shop.Add(new Info(7, "부리또", "양식", "쪽문", "하", false, 1, "부리또집"));
        Shop.Add(new Info(8, "사랑방하우스", "한식", "쪽문", "하", false, 1, "양념된 고기집"));
        Shop.Add(new Info(9, "나들목국밥", "한식", "쪽문", "중", false, 8, "국밥집"));
        Shop.Add(new Info(10, "파리에다녀온치킨", "치킨", "쪽문", "상", false, 1, "치킨집"));
        Shop.Add(new Info(11, "피가로", "양식", "쪽문", "상", false, 2, "화덕피자와 양식집"));
        Shop.Add(new Info(12, "봉추찜닭", "한식", "쪽문", "상", false, 2, "찜닭집"));
        Shop.Add(new Info(13, "예원", "일식", "쪽문", "중/상", false, 2, " 카레 일식집"));
        Shop.Add(new Info(14, "화석시대", "고깃집", "쪽문", "상", false, 3, "고기집"));
        Shop.Add(new Info(15, "신쭈꾸미", "한식", "쪽문", "중/상", false, 3, "쭈꾸미집"));
        Shop.Add(new Info(16, "락희식당", "고깃집", "쪽문", "상", false, 3, "고기 및 닭구이"));
        Shop.Add(new Info(17, "한솥", "한식", "쪽문", "하", false, 2, "도시락및 다른 음식도 존재"));
        Shop.Add(new Info(18, "산쪼메", "일식", "쪽문", "중", false, 2, "라멘과 덮밥류"));
        Shop.Add(new Info(19, "오꾸닭", "치킨", "쪽문", "상", false, 2, "여러 가지 치킨요리"));
        Shop.Add(new Info(20, "최고당", "양식", "쪽문", "중", false, 2, "돈까스 요리"));
        Shop.Add(new Info(21, "발발이추억", "한식", "쪽문", "상", false, 3, "족발집"));
        Shop.Add(new Info(22, "마녀치킨", "치킨", "쪽문", "상", false, 3, "치킨집"));
        Shop.Add(new Info(23, "69식당", "고깃집", "쪽문", "상", false, 3, "고깃집"));
        Shop.Add(new Info(24, "새마을식당", "고깃집", "쪽문", "중/상", false, 2, "고기와 7분김치찌개"));
        Shop.Add(new Info(25, "통큰돈까스", "양식", "쪽문", "중", false, 2, "양 많은 돈까스"));
        Shop.Add(new Info(26, "포베이", "양식", "쪽문", "중", false, 2, "베트남 쌀국수"));
        Shop.Add(new Info(27, "고수닭갈비", "한식", "쪽문", "상", false, 2, "닭갈비집"));
        Shop.Add(new Info(28, "밥풀", "한식", "쪽문", "중", false, 3, "여러가지 밥관련 요리"));
        Shop.Add(new Info(29, "참돈", "고깃집", "쪽문", "상", false, 3, "고기 무한리필"));
        Shop.Add(new Info(30, "더진국", "한식", "쪽문", "중", false, 3, "국밥종류"));
        Shop.Add(new Info(31, "마늘보쌈", "고깃집", "쪽문", "상", false, 3, "마늘 보쌈집"));
        Shop.Add(new Info(32, "서래", "고깃집", "쪽문", "상", false, 2,"고기집"));
        Shop.Add(new Info(33, "놀부보쌈", "한식", "쪽문", "상", false, 2, "보쌈집"));
        Shop.Add(new Info(34, "샤브향", "한식", "쪽문", "상", false, 2, "샤브샤브"));
        Shop.Add(new Info(35, "오라구", "양식", "쪽문", "상", false, 2, "양식집"));
        Shop.Add(new Info(36, "노랑통닭", "치킨", "쪽문", "상", false, 3, "치킨집"));
        Shop.Add(new Info(37, "치킨퐁", "치킨", "쪽문", "상", false, 2, "치킨집"));
        Shop.Add(new Info(38, "만계치킨", "치킨", "쪽문", "상", false, 3, "치킨집"));
        Shop.Add(new Info(39, "BHC", "치킨", "쪽문", "상", false, 3, "치킨집"));
        Shop.Add(new Info(40, "난타5000", "양식", "후문", "중", false, 5, "피자집"));
        Shop.Add(new Info(41, "미스터초밥", "일식", "후문", "상", false, 5, "초밥집"));
        Shop.Add(new Info(42, "놀부부대찌개", "한식", "후문", "상", false, 5, "부대찌개집"));
        Shop.Add(new Info(43, "간42", "한식", "후문", "하", false, 5, "4200원 여러음식들"));
        Shop.Add(new Info(44, "남다른감자탕", "한식", "후문", "상", false, 4, "감자탕및 전골요리"));
        Shop.Add(new Info(45, "혼끼", "일식", "후문", "중", false, 5, "덮밥과 라멘 요리"));
        Shop.Add(new Info(46, "오이시", "일식", "후문", "중", false, 5, "덮밥 및 라멘 덮밥"));
        Shop.Add(new Info(47, "신가네 매운 떡볶이", "분식", "후문", "하/중", false, 5, "떡볶이와 같은 분식"));
        Shop.Add(new Info(48, "쪼아저씨네 파스타", "양식", "후문", "상", false, 5, "파스타집"));
        Shop.Add(new Info(49, "틈새라면", "분식", "후문", "하", false, 5, "일식 아닌 라면"));
        Shop.Add(new Info(50, "명량핫도그", "후식", "후문", "하", false, 5, "핫도그집"));
        Shop.Add(new Info(51, "반미바게트", "후식", "후문", "하/중", false, 5, "바게트집"));
        Shop.Add(new Info(52, "깡패버거", "분식", "후문", "중", false, 5, "수제햄버거집"));
        Shop.Add(new Info(53, "홍대돈부리", "일식", "후문", "중", false, 5, "여러 가지 덮밥 요리"));
        Shop.Add(new Info(54, "1988고기뷔폐", "고깃집", "후문", "상", false, 5, "고기뷔폐"));
        Shop.Add(new Info(55, "마카나이", "일식", "후문", "상", false, 4, "15단계 매운라면집"));
        Shop.Add(new Info(56, "라스타", "분식", "후문", "중", false, 4, "일식 아닌 라면"));
        Shop.Add(new Info(57, "카츠앤 소바", "일식", "후문", "중/상", false, 4, "소바집"));
        Shop.Add(new Info(58, "부대통령", "한식", "후문", "하", false, 4, "부대찌개및 찌개류집"));
        Shop.Add(new Info(59, "도쿄스테이크", "양식", "후문", "상", false, 4, "스테이크집"));
        Shop.Add(new Info(60, "얼쑤", "한식", "후문", "중", false, 4, "고기국수집"));
        Shop.Add(new Info(61, "차이나궁", "중식", "후문", "중", false, 4, "여러 가지 중국음식집"));
        Shop.Add(new Info(62, "로니로티", "양식", "후문", "상", false, 4, " 다양한 양식집"));
        Shop.Add(new Info(63, "한마음 정육식당", "고깃집", "후문", "상", false, 4, "종합 고기집"));
        Shop.Add(new Info(64, "조봉순 상무국밥", "한식", "후문", "중", false, 4, "국밥집"));
        Shop.Add(new Info(65, "수내닭꼬치", "후식", "후문", "하", false, 4, "닭꼬치집"));
        Shop.Add(new Info(66, "바론떡볶이", "분식", "후문", "중", false, 4, "떡볶이집"));
        Shop.Add(new Info(67, "쭉심", "한식", "후문", "상", false, 4, "쭈꾸미 볶음집"));
        Shop.Add(new Info(68, "담소 소사골 국밥", "한식", "후문", "중", false, 4, "국밥집"));
        Shop.Add(new Info(69, "교촌치킨", "치킨", "후문", "상", false, 4, "치킨집"));
        Shop.Add(new Info(70, "청춘대패", "고깃집", "후문", "상", false, 4, "고깃집"));
        Shop.Add(new Info(71, "청춘덮밥", "한식", "후문", "중", false, 4, "고기덮밥집"));
        Shop.Add(new Info(72, "김피라", "퓨전", "후문", "중/상", false, 4, "한식과 양식"));
        Shop.Add(new Info(73, "콩불", "한식", "후문", "상", false, 4, "콩나물 불고기집"));
        Shop.Add(new Info(74, "고봉민 김밥", "한식", "후문", "중", false, 4, "김밥집"));
        Shop.Add(new Info(75, "통큰왕짬뽕", "중식", "후문", "중", false, 5, "여러가지 중식"));
        Shop.Add(new Info(76, "동산회관", "한식", "후문", "중/상", false,5 , "양념삼겹살"));
        Shop.Add(new Info(77, "응급실떡볶이", "분식", "후문", "중", false, 5, "떡볶이집"));
        Shop.Add(new Info(78, "당기요", "양식", "후문", "상", false, 5, "직접 배워온 양식집"));
        Shop.Add(new Info(79, "빨봉분식", "분식", "후문", "중", false,5 , "분식집"));
        Shop.Add(new Info(80, "갈무리", "고깃집", "후문", "상", false, 5, "무한리필 고깃집"));
        Shop.Add(new Info(81, "골목대장", "한식", "후문", "하", false, 5, "한식및 분식"));
        Shop.Add(new Info(82, "뽕신", "중식", "후문", "상", false, 5, "짬뽕전문집"));
        Shop.Add(new Info(83, "봉구스밥버거", "한식", "후문", "하", false, 6, "여러가지 종류의 밥버거"));
        Shop.Add(new Info(84, "곰이네분식", "분식", "후문", "중", false, 6, "여러분식집"));
        Shop.Add(new Info(85, "피자맘", "양식", "후문", "중", false, 6, "싼 피자집"));
        Shop.Add(new Info(86, "인도카레집(라즈)", "양식", "후문", "상", false, 6, "인도카레"));
        Shop.Add(new Info(87, "신전떡볶이", "분식", "후문", "중", false, 4, "떡볶이집"));
        Shop.Add(new Info(88, "파스타 부오노", "양식", "후문", "중", false, 4, "파스타집"));
        Shop.Add(new Info(89, "치킨마루", "치킨", "후문", "상", false, 4, "치킨집"));
        Shop.Add(new Info(90, "벼락냉면", "한식", "후문", "중", false, 4, "냉면과 고기"));
        Shop.Add(new Info(91, "삼계탕", "한식", "후문", "상", false, 4, "삼계탕집(이름을 모름)"));
        Shop.Add(new Info(92, "대감", "한식", "후문", "중", false, 6, "갈비밥"));
        Shop.Add(new Info(93, "예향정", "한식", "후문", "중/상", false, 6, "김치찌개집"));
        Shop.Add(new Info(94, "떡볶이대통령", "분식", "후문", "중", false, 6, "분식집"));
        Shop.Add(new Info(95, "바푸리포", "양식", "후문", "중", false, 6, "베트남 쌀국수"));
        Shop.Add(new Info(96, "또래오래", "치킨", "후문", "상", false, 6, "치킨집"));
        Shop.Add(new Info(97, "미스사이공", "양식", "후문", "중", false, 6, "베트남 쌀국수"));
        Shop.Add(new Info(98, "열평집밥", "한식", "후문", "중/상", false, 6, "김치찌개집"));
        Shop.Add(new Info(99, "버섯치즈닭갈비", "한식", "후문", "상", false, 7, "닭갈비집 이름을 잘 모름"));
        Shop.Add(new Info(100, "엽기떡볶이", "분식", "후문", "중", false, 7, "떡복이및 분식집"));
        Shop.Add(new Info(101, "돼지똥꼬", "한식", "후문", "상", false, 7, "막창집"));
        Shop.Add(new Info(102, "썬더치킨", "치킨", "후문", "상", false, 7, "치킨집"));
        Shop.Add(new Info(103, "매코미통닭발", "한식", "후문", "상", false, 7, "닭발집"));
        Shop.Add(new Info(104, "뼈대있는집", "한식", "후문", "상", false, 7, "뼈해장국집"));
        Shop.Add(new Info(105, "이태리반점", "퓨전", "후문", "상", false, 7, "중식과 양식"));
        Shop.Add(new Info(106, "부루스타", "분식", "후문", "중", false, 7, "떡복이집"));
        Shop.Add(new Info(107, "밥장인", "한식", "후문", "상", false, 4, "김치찌개를 밥에 비벼먹는집"));
        Shop.Add(new Info(108, "땡큐라멘", "일식", "후문", "상", false, 4, "라멘과 돈까스"));
        Shop.Add(new Info(109, "청춘다방", "분식", "후문", "상", false, 4, "떡복이집"));
        Shop.Add(new Info(110, "전대별식", "한식", "후문", "상", false, 4, "덮밥집"));
        Shop.Add(new Info(111, "B급식당", "퓨전", "후문", "상", false, 4, "여러가지음식"));
        Shop.Add(new Info(112, "마루와플", "후식", "후문", "하", false, 5, "와플집"));
        Shop.Add(new Info(113, "11:40치즈스틱", "후식", "후문", "하", false, 4, "치즈스틱집"));
        Shop.Add(new Info(114, "엉터리생고기", "고깃집", "쪽문", "상", false, 2, "고깃집"));








    }

}


