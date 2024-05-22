using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System.IO;
using System.Threading;

[SerializeField]
public class Region
{
    public int ID;
    public string Name;
    public Region(int ID, string Name)
    {
        this.ID = ID;
        this.Name = Name;
    }
}

[SerializeField]
public class Players
{
    // sinh viên viết tiếp code ở đây
    public int Id { get; set; }
    public string Name { get; set; }
    public int Score { get; set; }
    public Region PlayerRegion { get; set; }
    public Players(int id, string name, int score, Region region)
    {
        Id = id;
        Name = name;
        Score = score;
        PlayerRegion = region;
    }
}

public class ASM_MN : Singleton<ASM_MN>
{
    public List<Region> listRegion = new List<Region>();
    public List<Players> listPlayer = new List<Players>();

    private void Start()
    {
        createRegion();
    }

    public void createRegion()
    {
        listRegion.Add(new Region(0, "VN"));
        listRegion.Add(new Region(1, "VN1"));
        listRegion.Add(new Region(2, "VN2"));
        listRegion.Add(new Region(3, "JS"));
        listRegion.Add(new Region(4, "VS"));
    }

    public string calculate_rank(int score)
    {
        // sinh viên viết tiếp code ở đây

        if (score < 100)
        {
            return "Hang Dong";
        }
        else if (score > 100 && score < 500)
        {
            return "Hang Bac";
        }
        else if (score > 500 && score < 1000)
        {
            return "Hang Vang";
        }
        else
        {
            return "Kim Cuong";
        }

    }

    public void YC1()
    {
       

        Debug.Log("Thong tin cua nguoi choi da duoc luu");

        // Lấy các giá trị từ ScoreKeeper 
        string name = ScoreKeeper.Instance.GetUserName();
        int id = ScoreKeeper.Instance.GetID ();
        int idR = ScoreKeeper.Instance.GetIDregion();

        int score = ScoreKeeper.Instance.GetScore();

        string regionName = "";
        if (idR == 0)
        {
            regionName = "VN";
        }
        else if (idR == 1)
        {
            regionName = "VN1";
        }
        else if (idR == 2)
        {
            regionName = "VN2";
        }
        else if (idR == 3)
        {
            regionName = "JS";
        }
        else if (idR == 4)
        {
            regionName = "VS";
        }

        // Thêm thông tin người chơi mới khi nhập từ Text

        Region playerRegion = new Region(idR, regionName);
        Players player= new Players (id,name,score,playerRegion);
        listPlayer.Add(player);

      

        

    }
    public void YC2()
    {
        // sinh viên viết tiếp code ở đây
        Debug.Log("Danh sach nguoi choi");

        foreach (Players player in listPlayer)
        {
            Debug.Log("ID: " + player.Id + "| Name: " + player.Name + "| Scores: " + player.Score + "| Region: " + player.PlayerRegion.Name);
        }


    }
    public void YC3()
    {
        // sinh viên viết tiếp code ở đây
        int currentScore = listPlayer.FirstOrDefault(player => player.Name == "Nam").Score;

        Debug.Log("Thông tin các người chơi có điểm số bé hơn điểm số hiện tại của người chơi:");

        // Duyệt qua tất cả các người chơi
        foreach (Players player in listPlayer)
        {
            // Kiểm tra điểm số của người chơi
            if (player.Score < currentScore)
            {
                Debug.Log("ID: " + player.Id + "| Name: " + player.Name + "| Score: " + player.Score + "| Region: " + player.PlayerRegion.Name);
            }
        }
    }
    public void YC4()
    {
        // sinh viên viết tiếp code ở đây
    }
    public void YC5()
    {
        // sinh viên viết tiếp code ở đây
    }
    public void YC6()
    {
        // sinh viên viết tiếp code ở đây
    }
    public void YC7()
    {
        // sinh viên viết tiếp code ở đây
    }
    void CalculateAndSaveAverageScoreByRegion()
    {
        // sinh viên viết tiếp code ở đây
    }

}

