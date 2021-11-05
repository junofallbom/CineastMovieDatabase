const text = document.getElementsByClassName('movie-plot');
const buttonRead = document.getElementsByClassName('read-more');
const upVote = document.getElementsByClassName('thumbs-up');
const downVote = document.getElementsByClassName('thumbs-down');

buttonRead[0].addEventListener("click", function () {
    text[0].classList.toggle('active');

    if (this.innerHTML == "Read Less") {
        this.innerHTML = "Read More";
    }
    else {
        this.innerHTML = "Read Less";
    }
    this.className = this.className + " move";
});


async function likeMovie(id) {
    upVote[0].disabled = true;
    upVote[0].classList.add('button-hidden');
    const url = "https://grupp9.dsvkurs.miun.se/api/" + id + "/like";
    const response = await fetch(url);
    const movie = await response.json();
    document.getElementById('like').innerHTML = "Likes " + movie.numberOfLikes;
};
async function dislikeMovie(id) {
    downVote[0].disabled = true;
    downVote[0].classList.add('button-hidden');
    const url = "https://grupp9.dsvkurs.miun.se/api/" + id + "/dislike";
    const response = await fetch(url);
    const movie = await response.json();
    document.getElementById('dislike').innerHTML = "Dislikes " +movie.numberOfDislikes;
};

async function searchMovie() {
    const searchString = document.getElementById('Query').value;
    const select = document.getElementById('dataList');

    while (select.hasChildNodes()) {
        select.removeChild(select.firstChild);
    }
    const url = "https://www.omdbapi.com/?apikey=296ed584&s=" + searchString + "&page=1";

    const response = await fetch(url);
    const searchResult = await response.json();

    searchResult.Search.forEach(movie => {
        let option = document.createElement('option');
        option.value = movie.Title;
        option.text = movie.Title;
        select.appendChild(option);
    });

};


   


