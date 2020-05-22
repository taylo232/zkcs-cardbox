# zkcs Tech Notes

#### Design Choices:
- graph database to store connections (nodes and edges)
- local db to store node data
- linked by guid
- zettelkasten methodology

### Data definitions:

#### Graph DB (xkcd-links)

| Element | Data     | Type   |Definition                  |
| --------|----------|--------|----------------------------|
| Node    | id       | guid   | (** KEY **)  |
| Node    | label    | string |snappy display title        |
| Edge    | source   | guid   | guid                       |
| Edge    | target   | guid   | guid                       |
| Edge    | strength | int    | (0->9)                     |

#### Node DB (xkcd-main)
| Data      | Type   | Definition                                       |
|-----------|--------|--------------------------------------------------|
| id	    | guid   | (** KEY **)                                      |
| title     | string | snappy display title                             |
| created   | string | datetime node created                            |
| modified  | string | datetime node last modified                      |
| file		| string | filename of associated file or notes             |
| summary	| string | explanatory notes with keywords and sense of it  |
| tags		| (list) | manual tags to aid searching and discovery       |
| keynode   | bool   | starting point for a routing                     |



#### Local DB Implementation Options
##### Software:
- ** Sqlite ** (ease of use, minimal management)
- SQl Server Express
- Postgresql
- XML
- json
- text file
- MongoDB

##### Location:
- fanless (dev)
- parish  (prod)



