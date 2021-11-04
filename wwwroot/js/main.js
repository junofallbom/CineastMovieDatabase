const text = document.getElementsByClassName('movie-plot');
const buttonRead = document.getElementsByClassName('read-more');
const upVote = document.getElementsByClassName('thumbs-up');
const downVote = document.getElementsByClassName('thumbs-down');


buttonRead[0].addEventListener("click", function () {
    text[0].classList.toggle("active");

    if (this.innerHTML == "Read Less") {
        this.innerHTML = "Read More";
    }
    else {
        this.innerHTML = "Read Less";
    }

    this.className = this.className + " move";
});


async function likeMovie(id) {
    const url = "https://grupp9.dsvkurs.miun.se/api/" + id + "/like";
    const response = await fetch(url);
    const movie = await response.json();
    document.getElementById('like').innerHTML = movie.numberOfLikes;

};
async function dislikeMovie(id) {
    const url = "https://grupp9.dsvkurs.miun.se/api/" + id + "/dislike";
    const response = await fetch(url);
    const movie = await response.json();
    document.getElementById('dislike').innerHTML = movie.numberOfDislikes;
};

//downVote[0].onclick = function () {
//    downVote.disabled = true;
//}

//upVote[0].onclick = function () {
//    upVote.disabled = true;
//}


   


