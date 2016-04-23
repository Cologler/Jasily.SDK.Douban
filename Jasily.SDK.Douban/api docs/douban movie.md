# douban movie

## request url

> `GET http://api.douban.com/v2/movie/subject/{doubanId}`

### e.g.1

#### request

`GET http://api.douban.com/v2/movie/subject/25851657`

#### response json

``` json
{
  "rating": {
    "max": 10,
    "average": 8.7,
    "stars": "45",
    "min": 0
  },
  "reviews_count": 7,
  "wish_count": 448,
  "collect_count": 407,
  "douban_site": "",
  "year": "2015",
  "images": {
    "small": "http://img4.douban.com/view/movie_poster_cover/ipst/public/p2236401229.jpg",
    "large": "http://img4.douban.com/view/movie_poster_cover/lpst/public/p2236401229.jpg",
    "medium": "http://img4.douban.com/view/movie_poster_cover/spst/public/p2236401229.jpg"
  },
  "alt": "http://movie.douban.com/subject/25851657/",
  "id": "25851657",
  "mobile_url": "http://movie.douban.com/subject/25851657/mobile",
  "title": "我的青春恋爱物语果然有问题  第二季",
  "do_count": 615,
  "seasons_count": null,
  "schedule_url": "",
  "episodes_count": null,
  "genres": [
    "喜剧",
    "动画"
  ],
  "countries": [
    "日本"
  ],
  "casts": [
    {
      "avatars": {
        "small": "http://img4.douban.com/img/celebrity/small/50356.jpg",
        "large": "http://img4.douban.com/img/celebrity/large/50356.jpg",
        "medium": "http://img4.douban.com/img/celebrity/medium/50356.jpg"
      },
      "alt": "http://movie.douban.com/celebrity/1317111/",
      "id": "1317111",
      "name": "江口拓也"
    },
    {
      "avatars": {
        "small": "http://img3.douban.com/img/celebrity/small/14774.jpg",
        "large": "http://img3.douban.com/img/celebrity/large/14774.jpg",
        "medium": "http://img3.douban.com/img/celebrity/medium/14774.jpg"
      },
      "alt": "http://movie.douban.com/celebrity/1020667/",
      "id": "1020667",
      "name": "早见沙织"
    },
    {
      "avatars": {
        "small": "http://img3.douban.com/img/celebrity/small/FwKxGLwACSgcel_avatar_uploaded1365214470.31.jpg",
        "large": "http://img3.douban.com/img/celebrity/large/FwKxGLwACSgcel_avatar_uploaded1365214470.31.jpg",
        "medium": "http://img3.douban.com/img/celebrity/medium/FwKxGLwACSgcel_avatar_uploaded1365214470.31.jpg"
      },
      "alt": "http://movie.douban.com/celebrity/1327811/",
      "id": "1327811",
      "name": "东山奈央"
    },
    {
      "avatars": {
        "small": "http://img3.douban.com/img/celebrity/small/51934.jpg",
        "large": "http://img3.douban.com/img/celebrity/large/51934.jpg",
        "medium": "http://img3.douban.com/img/celebrity/medium/51934.jpg"
      },
      "alt": "http://movie.douban.com/celebrity/1321981/",
      "id": "1321981",
      "name": "小松未可子"
    }
  ],
  "current_season": null,
  "original_title": "やはり俺の青春ラブコメはまちがっている。続",
  "summary": "",
  "subtype": "tv",
  "directors": [
    {
      "avatars": null,
      "alt": null,
      "id": null,
      "name": "及川啓"
    }
  ],
  "comments_count": 130,
  "ratings_count": 601,
  "aka": [
    "やはり俺の青春ラブコメはまちがっている。 2期"
  ]
}
```