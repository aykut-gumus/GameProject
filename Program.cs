using GameProject;
using GameProject.Concrete;
using GameProject.Entities;


UserValidationManager userValidationManager = new UserValidationManager();

Gamer gamer1 = new Gamer()
{
    Id = 1,
    FirstName = "Fatih",
    LastName = "Hasır",
    DateOfBirth = 1992,
    NationalityId = 12345678910
};


Gamer gamer2 = new Gamer()
{
    Id = 2,
    FirstName = "Oya",
    LastName = "Benli",
    DateOfBirth = 1989,
    NationalityId = 14725836970
};


Gamer gamer3 = new Gamer()
{
    Id = 3,
    FirstName = "Hasan",
    LastName = "Pırıltı",
    DateOfBirth = 1987,
    NationalityId = 36925814790
};

GamerManager gamerManager = new GamerManager();
gamerManager.Add(gamer1);
gamerManager.Delete(gamer2);
gamerManager.Update(gamer3);

Game game1 = new Game()
{
    GameId = 1,
    GameName = "PES 2022",
    GamePrice = 425,
};

Game game2 = new Game()
{
    GameId = 2,
    GameName = "CS Go",
    GamePrice = 215,
};

Game game3 = new Game()
{
    GameId = 3,
    GameName = "Valorant",
    GamePrice = 360,
};

GameManager gameManager = new GameManager();
gameManager.Add(game1);
gameManager.Delete(game2);
gameManager.Update(game3);

Campaign campaign1 = new Campaign()
{
    Id = 1,
    CampaignName = "Yaz Tatili Kampanyası",
    Discount = 10,
};

CampaignManager campaignManager = new CampaignManager();
campaignManager.Add(campaign1);

