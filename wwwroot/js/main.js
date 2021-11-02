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

//upVote[0].addEventListener("click", function () {
//    var xButtonValue = $(this).val();
//    console.log("hej");
//    $.post("Home.LikeMovie",
//        {
//            value: xButtonValue,
//        },
//        function (data, status) {
//            alert("Data: " + data + "\nStatus: " + status);
//        });
//});

//downVote[0].addEventListener("click", function () {
//    fetch("https://grupp9.dsvkurs.miun.se/api/" + movie.imdbID + "/dislike")
//});

//$(upVote).click(function () {
        
//    });

function likeMovie() {
    const url = "https://grupp9.dsvkurs.miun.se/api/" + movie.imdbID + "/like";
    console.log(url);

};

//document.querySelector('#upvoteButton').onclick = function () { like() };
//function like() {

   


