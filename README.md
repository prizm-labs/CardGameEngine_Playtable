# CardGameEngine_Playtable
A card game engine for the Playtable that uses iTween and TouchScript.

### Classes
- CardManager
- Card
- Deck

### CardManager.cs
#### Properties
| Property        | Type          | Description  |
| --------------- | ------------- | ------------ |
| cardPrefab      | GameObject    | Holds the Card prefab. Can be referenced for default values. |
| deckPrefab      | GameObject    | Holds the Deck prefab. Can be referenced for default values. |

#### Methods
| Method          | Parameters       | Return        | Description  |
| --------------- | ---------------- | ------------- | ------------ |
| createDeck      | Vector2 pos      | GameObject    | Creates an instance of a deckPrefab at a given position. |
| createDeck      | float x, float y | GameObject    | Creates an instance of a deckPrefab at a given position. |
| createCard      | Vector2 pos      | GameObject    | Creates an instance of a cardPrefab at a given position. |
| createCard      | float x, float y | GameObject    | Creates an instance of a cardPrefab at a given position. |

### Card.cs
#### Properties
| Property        | Type          | Description  |
| --------------- | ------------- | ------------ |
| collidedObject  | GameObject    | The object the card collides with. Null by default. |
| frontImage      | GameObject    | Holds the GameObject that contains the Image component for the front image of the card. |
| backImage       | GameObject    | Holds the GameObject that contains the Image component for the back image of the card. |

#### Methods
| Method          | Parameters       | Return  | Description  |
| --------------- | ---------------- | ------- | ------------ |
| flip            |                  | void    | Flips the card facedown/up. |
| setSpriteFront  | Sprite s         | void    | Sets the front Sprite of the card to a given Sprite. |
| setSpriteBack   | Sprite s         | void    | Sets the back Sprite of the card to a give Sprite.   |

### Deck.cs
#### Properties
| Property        | Type             | Description  |
| --------------- | ---------------- | ------------ |
| cardPrefab      | GameObject       | Holds the Card prefab. Can be referenced for default values. |
| cards           | List<GameObject> | Holds the GameObjects of the cards currently in the deck.    |
| cardLibrary     | List<GameObject> | Holds the GameObjects of the cards that have been registered by the deck and will return on recall().    |

#### Methods
| Method          | Parameters       | Return  | Description  |
| --------------- | ---------------- | ------- | ------------ |
| createCard      |                  | void    | Creates an instance of a cardPrefab and adds/registers it to the deck. |
| add             | GameObject card  | void    | Adds a card to the deck. A card that collides with a deck will be added to the deck. |
| register        | GameObject card  | void    | Registers a card to the deck. That card will be recalled to the deck on recall(). |
| deal            | GameObject card, Vector3 pos | void | Deals a given card to the given position. |
| recall          |                  | void    | Returns registered cards back to the deck. |
| shuffle         |                  | void    | Shuffles the deck by selection. This will be updated in the future. |
| isEmpty         |                  | bool    | Returns true if the deck is empty, false otherwise. |
