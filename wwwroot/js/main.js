const text = document.getElementsByClassName('movie-plot');
const buttonRead = document.getElementsByClassName('read-more');
const upVote = document.getElementsByClassName('thumbs-up');
const downVote = document.getElementsByClassName('thumbs-down');


buttonRead[0].addEventListener("click", function () {
    text[0].classList.toggle("active");

    //if (this.innerHTML == "Read More") {
    //    this.innerHTML = "Read Less";
    //}
    //else {
    //    this.innerHTML = "Read More";
    //}

    this.className = this.className + " move";
});

function likeMovie(movie) {
    const url = "https://grupp9.dsvkurs.miun.se/api/" + movie.imdbID + "/like";
};



