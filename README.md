
# BookStoreWebAPI

BookStoreWebAPI is a simple REST API designed for managing a book store. It provides endpoints for basic operations such as adding, updating, and deleting books and authors. 




## Tech Stack

- **ASP.NET Core**: The API is built using ASP.NET Core for cross-platform compatibility.
- **Entity Framework**: Database interactions are handled using Entity Framework.
- **Swagger**: Explore and test the API easily with Swagger documentation.


## API Reference
### Authors

#### Get all Authors

```http
  GET /api/Authors
```
#### Success Response

**Code** : `200 OK`

**Content example**

```json
[
  {
    "id": 0,
    "firstName": "string",
    "lastname": "string",
    "bio": "string"
  }
]

```
---
#### Get Author by Id

```http
  GET /api/Authors/${id}
```

| Parameter | Type     | Description                       |
| :-------- | :------- | :-------------------------------- |
| `id`      | `int` | **Required**. Id of Author to fetch |

#### Success Response

**Code** : `200 OK`

**Content example**

```json
{
  "id": 0,
  "firstName": "string",
  "lastname": "string",
  "bio": "string"
}

```
---

#### Create new Author

```http
  POST /api/Authors
```
Request body
```json
{
    "firstName": string,
    "lastName": string,
    "bio": string
}
```
---

#### Update Author

```http
  PUT /api/Authors/${id}
```
| Parameter | Type     | Description                       |
| :-------- | :------- | :-------------------------------- |
| `id`      | `int` | **Required**. Id of Author to update |

Request body
```json
{
    "firstName": string,
    "lastName": string,
    "bio": string
}
```
---

#### Delete Author

```http
  DELETE /api/Authors/${id}
```
| Parameter | Type     | Description                       |
| :-------- | :------- | :-------------------------------- |
| `id`      | `int` | **Required**. Id of Author to delete |

---
### Books
#### Get all Books

```http
  GET /api/Books
```

#### Success Response

**Code** : `200 OK`

**Content example**

```json
[
  {
    "id": 0,
    "title": "string",
    "image": "string",
    "authorId": 0,
    "price": 0,
    "authorName": "string"
  }
]

```
---
#### Get Book by Id

```http
  GET /api/Books/${id}
```

| Parameter | Type     | Description                       |
| :-------- | :------- | :-------------------------------- |
| `id`      | `int` | **Required**. Id of Book to fetch |

#### Success Response

**Code** : `200 OK`

**Content example**

```json
{
    "id": 0,
    "title": "string",
    "image": "string",
    "authorId": 0,
    "price": 0,
    "authorName": "string"
  }

```

---

#### Create new Book

```http
  POST /api/Books
```
Request body
```json
{
  "title": "string",
  "year": int,
  "isbn": "string",
  "summary": "string",
  "image": "string",
  "price": int,
  "authorId": int
}
```

---

#### Update Book

```http
  PUT /api/Books/${id}
```
| Parameter | Type     | Description                       |
| :-------- | :------- | :-------------------------------- |
| `id`      | `int` | **Required**. Id of Book to update |

Request body
```json
{
  "title": "string",
  "year": int,
  "isbn": "string",
  "summary": "string",
  "image": "string",
  "price": int
}
```

---

#### Delete Book

```http
  DELETE /api/Book/${id}
```
| Parameter | Type     | Description                       |
| :-------- | :------- | :-------------------------------- |
| `id`      | `int` | **Required**. Id of Book to delete |

## Acknowledgements

 - [Swagger](https://swagger.io/)

