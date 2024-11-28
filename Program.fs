// Define the Genre 
type Genre =
    | Horror
    | Drama
    | Thriller
    | Comedy
    | Fantasy
    | Sport

//  the Director record type
type Director = {
    Name: string
    Movies: int
}

// Movie record type
type Movie = {
    Name: string
    RunLength: int
    Genre: Genre
    Director: Director
    IMDBRating: float
}

//Create movie instances
let director1 = { Name = "Director A"; Movies = 5 }
let director2 = { Name = "Director B"; Movies = 10 }
let director3 = { Name = "Director C"; Movies = 3 }

let movie1 = { Name = "CODA"; RunLength = 111; Genre = Drama; Director = director1; IMDBRating = 8.1 }
let movie2 = { Name = "belfast"; RunLength = 95; Genre = Horror; Director = director2; IMDBRating = 7.1 }
let movie3 = { Name = "don't look up"; RunLength = 150; Genre = Thriller; Director = director1; IMDBRating = 7.5 }
let movie4 = { Name = "drive my car"; RunLength = 111; Genre = Comedy; Director = director3; IMDBRating = 7.8 }
let movie5 = { Name = "dune"; RunLength = 90; Genre = Fantasy; Director = director2; IMDBRating = 6.9 }
let movie6 = { Name = "king richard"; RunLength = 145; Genre = Sport; Director = director3; IMDBRating = 7.9 }

//  Create a list of movies
let movies = [movie1; movie2; movie3; movie4; movie5; movie6]

// Find probable Oscar winners (IMDB rating > 7.4)
let probableOscarWinners = 
    movies |> List.filter (fun movie -> movie.IMDBRating > 7.4)

// Convert movie run length to hours and minutes
let convertRunLengthToHoursAndMinutes (runLength: int) =
    let hours = runLength / 60
    let minutes = runLength % 60
    sprintf "%dh %dmin" hours minutes

let moviesWithConvertedRunLengths = 
    movies |> List.map (fun movie -> convertRunLengthToHoursAndMinutes movie.RunLength)

// Printing the results
printfn "Probable Oscar Winners:"
probableOscarWinners |> List.iter (fun movie -> printfn "%s with IMDB rating: %.1f" movie.Name movie.IMDBRating)

printfn "\nMovies with Run Length in Hours and Minutes:"
moviesWithConvertedRunLengths |> List.iter (fun runLength -> printfn "%s" runLength)
