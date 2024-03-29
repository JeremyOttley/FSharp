module Underground = 
   let Stations =
      [|
         "Acton Town"
         "Aldgate"
         "Aldgate East"
         "All Saints"
         "Alperton"
         "Angel"
         "Archway"
         "Arnos Grove"
         "Arsenal"
         "Baker Street"
         "Balham"
         "Bank"
         "Barbican"
         "Barking"
         "Barkingside"
         "Barons Court"
         "Bayswater"
         "Beckton"
         "Beckton Park"
         "Becontree"
         "Belsize Park"
         "Bethnal Green"
         "Blackfriars"
         "Blackhorse Road"
         "Blackwall"
         "Bond Street"
         "Borough"
         "Boston Manor"
         "Bounds Green"
         "Bow Church"
         "Bow Road"
         "Brent Cross"
         "Bromley-By-Bow"
         "Burnt Oak"
         "Caledonian Road"
         "Camden Town"
         "Canary Wharf"
         "Cannon Street"
         "Canons Park"
         "Chalk Farm"
         "Chancery Lane"
         "Charing Cross"
         "Chigwell"
         "Chiswick Park"
         "Clapham Common"
         "Clapham North"
         "Clapham South"
         "Colindale"
         "Colliers Wood"
         "Covent Garden"
         "Crossharbour & London Arena"
         "Custom House"
         "Cyprus"
         "Dagenham East"
         "Dagenham Heathway"
         "Devons Road"
         "Dollis Hill"
         "Ealing Broadway"
         "Ealing Common"
         "Earl's Court"
         "Eastcote"
         "East Acton"
         "East Finchley"
         "East Ham"
         "East India"
         "East Putney"
         "Edgware"
         "Edgware Road (B)"
         "Edgware Road (C)"
         "Elephant & Castle"
         "Elm Park"
         "Embankment"
         "Euston"
         "Euston Square"
         "Fairlop"
         "Farringdon"
         "Finchley Central"
         "Finchley Road"
         "Finsbury Park"
         "Fulham Broadway"
         "Gallions Reach"
         "Gants Hill"
         "Gloucester Road"
         "Golders Green"
         "Goldhawk Road"
         "Goodge Street"
         "Grange Hill"
         "Great Portland Street"
         "Greenford"
         "Green Park"
         "Gunnersbury"
         "Hainault"
         "Hammersmith"
         "Hampstead"
         "Hanger Lane"
         "Harlesden"
         "Harrow & Wealdston"
         "Harrow-on-the-Hill"
         "Hatton Cross"
         "Heathrow Terminals 1, 2 & 3"
         "Heathrow Terminal 4"
         "Hendon Central"
         "Heron Quays"
         "High Street Kensington"
         "Highbury & Islington"
         "Highgate"
         "Hillingdon"
         "Holborn"
         "Holland Park"
         "Holloway Road"
         "Hornchurch"
         "Hounslow Central"
         "Hounslow East"
         "Hounslow West"
         "Hyde Park Corner"
         "Ickenham"
         "Island Gardens"
         "Kennington"
         "Kensal Green"
         "Kensington (Olympia)"
         "Kentish Town"
         "Kenton"
         "Kew Gardens"
         "Kilburn"
         "Kilburn Park"
         "Kingsbury"
         "King's Cross St. Pancras"
         "Knightsbridge"
         "Ladbroke Grove"
         "Lambeth North"
         "Lancaster Gate"
         "Latimer Road"
         "Leicester Square"
         "Leyton"
         "Leytonstone"
         "Limehouse"
         "Liverpool Street"
         "London Bridge"
         "Maida Vale"
         "Manor House"
         "Mansion House"
         "Marble Arch"
         "Marylebone"
         "Mile End"
         "Mill Hill East"
         "Monument"
         "Moorgate"
         "Moor Park"
         "Morden"
         "Mornington Crescent"
         "Mudchute"
         "Neasden"
         "Newbury Park"
         "Northfields"
         "Northolt"
         "Northwick Park"
         "Northwood"
         "Northwood Hills"
         "North Acton"
         "North Ealing"
         "North Harrow"
         "North Wembley"
         "Notting Hill Gate"
         "Old Street"
         "Osterley"
         "Oval"
         "Oxford Circus"
         "Paddington"
         "Park Royal"
         "Parsons Green"
         "Perivale"
         "Picadilly Circus"
         "Pimlico"
         "Pinner"
         "Plaistow"
         "Poplar"
         "Preston Road"
         "Prince Regent"
         "Putney Bridge"
         "Queen's Park"
         "Queensbury"
         "Queensway"
         "Ravenscourt Park"
         "Rayners Lane"
         "Redbridge"
         "Regent's Park"
         "Richmond"
         "Roding Valley"
         "Rotherhithe"
         "Royal Albert"
         "Royal Oak"
         "Royal Victoria"
         "Ruislip"
         "Ruislip Manor"
         "Russell Square"
         "Seven Sisters"
         "Shadwell"
         "Shepherd's Bush (C)"
         "Shepherd's Bush (H)"
         "Shoreditch"
         "Sloane Square"
         "Snaresbrook"
         "Southfields"
         "South Ealing"
         "South Harrow"
         "South Kensington"
         "South Kenton"
         "South Quay"
         "South Ruislip"
         "South Wimbledon"
         "South Woodford"
         "Stamford Brook"
         "Stanmore"
         "Stepney Green"
         "Stockwell"
         "Stonebridge Park"
         "Stratford"
         "St. James's Park"
         "St. John's Wood"
         "St. Paul's"
         "Sudbury Hill"
         "Sudbury Town"
         "Surrey Quays"
         "Swiss Cottage"
         "Temple"
         "Tooting Bec"
         "Tooting Broadway"
         "Tottenham Court Road"
         "Tottenham Hale"
         "Tower Gateway"
         "Tower Hill"
         "Tufnell Park"
         "Turnham Green"
         "Turnpike Lane"
         "Upminster"
         "Upminster Bridge"
         "Upney"
         "Upton Park"
         "Uxbridge"
         "Vauxhall"
         "Victoria"
         "Walthamstow Central"
         "Wanstead"
         "Wapping"
         "Warren Street"
         "Warwick Avenue"
         "Waterloo"
         "Wembley Central"
         "Wembley Park"
         "Westbourne Park"
         "Westferry"
         "Westminster"
         "West Acton"
         "West Brompton"
         "West Finchley"
         "West Ham"
         "West Hampstead"
         "West Harrow"
         "West India Quay"
         "West Kensington"
         "West Ruislip"
         "Whitechapel"
         "White City"
         "Willesden Green"
         "Willesden Junction"
         "Wimbledon"
         "Wimbledon Park"
         "Woodford"
         "Woodside Park"
         "Wood Green"
         "Brixton"
         "Amersham"
         "Bermondsey"
         "Chesham"
         "Chalfont & Latimer"
         "Chorleywood"
         "Rickmansworth"
         "Croxley"
         "Watford"
         "Ruislip Gardens"
         "High Barnet"
         "Totteridge & Whetstone"
         "Cockfosters"
         "Oakwood"
         "Southgate"
         "Epping"
         "Theydon Bois"
         "Debden"
         "Loughton"
         "Buckhurst Hill"
         "Pudding Mill Lane"
         "Southwark"
         "Canada Water"
         "Canning Town"
         "North Greenwich"
         "Cutty Sark"
         "Greenwich"
         "Deptford Bridge"
         "Elverson Road"
         "Lewisham"
         "New Cross"
         "New Cross Gate"
         "West Silvertown"
         "King George V"
         "Pontoon Dock"
         "London City Airport"
      |] 
