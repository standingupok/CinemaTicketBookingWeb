"use strict";
const radioButtons = document.querySelectorAll('input[type="radio"]');
const radioLabel = document.querySelectorAll(".radio-label");
const screeningDate = document.getElementById("screening-date");
const screeningId = document.getElementById("screening-id");
const filmId = document.getElementById("film-id");
const bookBtn = document.getElementById("book-btn");
const seatNumber = document.getElementById("seat-number");

const LIST_TICKET = "LIST_TICKET";
let ticketArr = JSON.parse(getFromStorage(LIST_TICKET, null)) ?? [];

let dateArr = [];
let screeningHourId = [];
let seatArr = [];

//let filterTicketArr = ticketArr.filter(ticket => ticket.filmId == filmId.value);

const checkPickedchairs = function () {
    seatArr = ticketArr;
    seatArr = seatArr.filter(ticket => ticket.film == filmId.value);
    if (screeningDate.value != null && screeningId.value != null) {
        seatArr = seatArr.filter(ticket => ticket.screenDate == screeningDate.value);
        seatArr = seatArr.filter(ticket => ticket.screenId == screeningId.value);

        for (let i = 0; i < seatArr.length; i++) {
            radioLabel[seatArr[i].seat].classList.add("click-non");
        }
    }
    
}

const isDateBeforeToday = (dateString) => {
    const selectedDate = new Date(dateString);
    console.log(selectedDate);
    const today = new Date();
    console.log(today);
    return selectedDate < today;
};

screeningDate.addEventListener("change", function () {
    const selectedDate = this.value;
    if (isDateBeforeToday(selectedDate)) {
        // Nếu ngày đặt vé trước ngày hiện tại, hiển thị thông báo
        alert("Ngày đặt vé phải sau ngày hiện tại!");
        // Hoặc có thể sử dụng thư viện toast để hiển thị toast
        // Ví dụ: showToast("Ngày đặt vé phải sau ngày hiện tại!");
        // showToast là một hàm tùy thuộc vào thư viện toast bạn đang sử dụng
    }
    else {
        radioLabel.forEach(label => {
            label.classList.remove("click-non");
        });
        if (ticketArr == null) {
            return;
        }

        else {
            checkPickedchairs();
        }
    }
});

screeningId.addEventListener("change", function () {
    radioLabel.forEach(label => {
        label.classList.remove("click-non");
    });
    if (ticketArr == null) {
        return;
    }

    else {
        checkPickedchairs();
    }

});

bookBtn.addEventListener("click", function () {

    const data = {
        seat: parseInt(seatNumber.value),
        screenDate: screeningDate.value,
        screenId: screeningId.value,
        film: filmId.value,
    }
    ticketArr.push(data);
    saveToStorage(LIST_TICKET, JSON.stringify(ticketArr));
});

radioButtons.forEach(btn => {
    btn.addEventListener("change", function () {
        seatNumber.value = this.value; 
    })
})