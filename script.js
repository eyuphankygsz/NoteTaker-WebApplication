"use strict";

var username;
const users = [
  {
    username: "eyup",
    password: "1111",
    notes: [
      {
        id: 0,
        noteCreator: "eyup",
        noteTitle: "Toplantı Sonuçları - Not Alma Sitesi Geliştirme Toplantısı",
        noteContent: `Tarih: 8 Haziran 2024
Saat: 14:00 - 15:30

Katılımcılar:

Ahmet Yılmaz (Proje Yöneticisi)
Eyüphan Kaygusuz (Yazılım Geliştirici)
Mehmet Kaya (UI/UX Tasarımcısı)
Ayşe Özkan (Ürün Yöneticisi)
Fatma Aksoy (Müşteri Temsilcisi)
Gündem:

Proje Durumu
Kullanıcı Geri Bildirimleri
Yeni Özellikler
Takvim ve Yol Haritası
1. Proje Durumu

Çoğu hedefe ulaşıldı. (Ahmet Yılmaz)
Veri senkronizasyonu ve offline erişimde ilerleme sağlandı. (Eyüphan Kaygusuz)
UI güncellemeleri yapıldı. (Mehmet Kaya)
2. Kullanıcı Geri Bildirimleri

Kullanıcılar hızdan memnun, ek özellikler istiyor: senkronizasyon, etiketleme, filtreleme. (Fatma Aksoy)
3. Yeni Özellikler

Etiket ekleme, gelişmiş arama, daha iyi senkronizasyon, yardım merkezi. (Ayşe Özkan)
Teknik detaylar ve zorluklar. (Eyüphan Kaygusuz)
4. Takvim ve Yol Haritası

Haziran: etiketleme, arama
Temmuz: senkronizasyon
Ağustos: yardım merkezi
Haftalık kontrol toplantıları
Sonuç ve Eylem Adımları:

Geri bildirim analizi, yeni özelliklerin geliştirilmesi, haftalık toplantılar.
Bir sonraki toplantı: 22 Haziran 2024, 14:00

Hazırlayan:
Eyüphan Kaygusuz`,
        addedUsers: ["omer"],
      },
      {
        id: 1,
        noteCreator: "omer",
        noteTitle: "Ortak Noktalar",
        noteContent:
          "Lorem ipsum dolor sit amet consectetur adipisicing elit. Itaque, amet odio iste error delectus aspernatur ut omnis at molestias, fugit quis. Laudantium qui aut fuga!",
        addedUsers: ["eyup"],
      },
    ],
  },
  {
    username: "baran",
    password: "2222",
    notes: [],
  },
  {
    username: "omer",
    password: "3333",
    notes: [
      {
        id: 0,
        noteCreator: "eyup",
        noteTitle: "Toplantı Sonuçları - Not Alma Sitesi Geliştirme Toplantısı",
        noteContent: `Tarih: 8 Haziran 2024
Saat: 14:00 - 15:30

Katılımcılar:

Ahmet Yılmaz (Proje Yöneticisi)
Eyüphan Kaygusuz (Yazılım Geliştirici)
Mehmet Kaya (UI/UX Tasarımcısı)
Ayşe Özkan (Ürün Yöneticisi)
Fatma Aksoy (Müşteri Temsilcisi)
Gündem:

Proje Durumu
Kullanıcı Geri Bildirimleri
Yeni Özellikler
Takvim ve Yol Haritası
1. Proje Durumu

Çoğu hedefe ulaşıldı. (Ahmet Yılmaz)
Veri senkronizasyonu ve offline erişimde ilerleme sağlandı. (Eyüphan Kaygusuz)
UI güncellemeleri yapıldı. (Mehmet Kaya)
2. Kullanıcı Geri Bildirimleri

Kullanıcılar hızdan memnun, ek özellikler istiyor: senkronizasyon, etiketleme, filtreleme. (Fatma Aksoy)
3. Yeni Özellikler

Etiket ekleme, gelişmiş arama, daha iyi senkronizasyon, yardım merkezi. (Ayşe Özkan)
Teknik detaylar ve zorluklar. (Eyüphan Kaygusuz)
4. Takvim ve Yol Haritası

Haziran: etiketleme, arama
Temmuz: senkronizasyon
Ağustos: yardım merkezi
Haftalık kontrol toplantıları
Sonuç ve Eylem Adımları:

Geri bildirim analizi, yeni özelliklerin geliştirilmesi, haftalık toplantılar.
Bir sonraki toplantı: 22 Haziran 2024, 14:00

Hazırlayan:
Eyüphan Kaygusuz`,
        addedUsers: ["omer"],
      },
      {
        id: 1,
        noteCreator: "omer",
        noteTitle: "Ortak Noktalar",
        noteContent:
          "Lorem ipsum dolor sit amet consectetur adipisicing elit. Itaque, amet odio iste error delectus aspernatur ut omnis at molestias, fugit quis. Laudantium qui aut fuga!",
        addedUsers: ["eyup"],
      },
    ],
  },
];

var noteIndexCounter = 2;

function tryLogin() {
  checkEmptyFields();
  var userFound = false;
  for (let i = 0; i < users.length; i++) {
    const user = users[i];

    if (
      user.username === usernameInput.value &&
      user.password == passwordInput.value
    ) {
      document.querySelector(".header").children[1].classList.toggle("hidden");
      document.querySelector(".header").children[2].classList.toggle("hidden");
      document.querySelector(".showroom").classList.toggle("hidden");
      document.querySelector(".mainContent").classList.toggle("hidden");
      document.querySelector(".welcome").textContent =
        "Welcome, " + usernameInput.value;
      userFound = true;
      username = usernameInput.value;

      getNotes();
      return;
    }
  }
  if (!userFound) alert("Wrong credentials!");
}

function checkEmptyFields() {
  if (usernameInput.value.length == 0 || passwordInput.value.length == 0) {
    alert("Username and Password cannot be empty!");
  }
}
function onFocusOutField(element) {
  if (element.value.length == 0) element.style.outline = "2px solid red";
  else element.style.outline = "none";
}
document.querySelector("#loginButton").addEventListener("click", tryLogin);

const usernameInput = document.querySelector("#usernameField");
usernameInput.addEventListener("focusout", () =>
  onFocusOutField(usernameInput)
);
const passwordInput = document.querySelector("#passwordField");
passwordInput.addEventListener("focusout", () =>
  onFocusOutField(passwordInput)
);

//-----------------------
usernameInput.value = "eyup";
passwordInput.value = "1111";
tryLogin();
//-----------------------

var selectedNote;

function getNotes() {
  var notes;
  for (let i = 0; i < users.length; i++)
    if (username == users[i].username) {
      notes = users[i].notes;
      break;
    }

  const noteHolder = document.querySelector("#mainNotes");
  const noteChildCount = noteHolder.children.length;
  for (let i = 0; i < noteChildCount; i++) {
    noteHolder.removeChild(noteHolder.children[0]);
  }
  for (let i = 0; i < notes.length; i++) {
    const noteInformation = notes[i];
    const newNote = document.createElement("button");
    newNote.classList.add("note");

    var title = noteInformation.noteTitle;
    if (title.length > 22) title = title.substring(0, 30).concat("...");
    newNote.innerHTML = `
            <div class="noteInfo">
                <p class="noteID">${noteInformation.id}</p>
                <p class="noteTitle"><b>${title}</b></p>
                <p class="noteCreator">Creator: ${noteInformation.noteCreator}</p>
            </div>`;
    newNote.addEventListener("click", () => selectNote(noteInformation.id));
    noteHolder.appendChild(newNote);
  }
}

function selectNote(id) {
  for (let i = 0; i < users.length; i++)
    if (username == users[i].username) {
      const u = users[i];
      for (let j = 0; j < u.notes.length; j++) {
        if (id == u.notes[j].id) selectedNote = u.notes[j];
      }
      break;
    }

  document.querySelector("#noteContent").value = selectedNote.noteContent;
  document.querySelector("#noteTitle").value = selectedNote.noteTitle;
}

function searchUser() {
  const usernameSearchField = document.querySelector(
    "#usernameSearchField"
  ).value;
  if (usernameSearchField.length < 3)
    alert("Please enter at least 3 characters!");

  for (let i = foundUserCombobox.children.length - 1; i >= 1; i--)
    foundUserCombobox.removeChild(foundUserCombobox.children[i]);

  for (let i = 0; i < users.length; i++) {
    const u = users[i];
    if (u.username.includes(usernameSearchField, 0)) {
      addUserToComboBox(u);
    }
  }
}
document.querySelector("#searchUserButton").addEventListener("click", searchUser);

function createText() {
  document.querySelector("#noteTitle").value = "Untitled";
  document.querySelector("#noteContent").value = "";

  const noteHolder = document.querySelector("#mainNotes");
  const newNote = document.createElement("button");
  newNote.classList.add("note");
  const newID = noteIndexCounter;
  noteIndexCounter++;
  newNote.innerHTML = `
            <div class="noteInfo">
                <p class="noteID">${newID}</p>
                <p class="noteTitle"><b>${"Untitled"}</b></p>
                <p class="noteCreator">Creator: ${username}</p>
            </div>`;

  newNote.addEventListener("click", () => selectNote(newID));
  noteHolder.appendChild(newNote);

  for (let i = 0; i < users.length; i++) {
    if (users[i].username == username) {
      const notePush = {
        id: newID,
        noteCreator: username,
        noteTitle: "Untitled",
        noteContent: "",
        addedUsers: [],
      };
      users[i].notes.push(notePush);
    }
  }
  selectNote(newID);
}
document.querySelector("#createText").addEventListener("click", createText);




function deleteText() {
  if(!selectedNote){
    alert("You have to choose a note!");
    return;
  }

  document.querySelector("#noteTitle").value = "";
  document.querySelector("#noteContent").value = "";

  const noteHolder = document.querySelector("#mainNotes");
  //Other users
  for (let i = 0; i < users.length; i++) {
    if (selectedNote.addedUsers.includes(users[i].username)) {
      for (let j = 0; j < users[i].notes.length; j++) {
        const note = users[i].notes[j];
        if(note.id == selectedNote.id)
          users[i].notes.splice(j,1);
      }
    }
  }
  //Us
  for (let i = 0; i < users.length; i++) {
    if (users[i].username == username) {
      for (let j = 0; j < users[i].notes.length; j++) {
        const note = users[i].notes[j];
        if(note.id == selectedNote.id)
          users[i].notes.splice(j,1);
      }
    }
  }
  selectedNote = false;
  getNotes();
}
document.querySelector("#deleteText").addEventListener("click", deleteText);



function saveText() {
  if (!selectedNote) {
    alert("You have to select a note!");
    return;
  }
  const title = document.querySelector("#noteTitle").value;
  const content = document.querySelector("#noteContent").value;
  const id = selectedNote.id;
  for (let i = 0; i < users.length; i++) {
    const u = users[i];
    for (let j = 0; j < u.notes.length; j++) {
      if (u.notes[j].id == id) {
        const note = u.notes[j];
        note.noteContent = content;
        note.noteTitle = title;
      }
    }
  }
}
document.querySelector("#saveText").addEventListener("click", saveText);

const foundUserCombobox = document.querySelector("#foundUsers");
for (let i = 0; i < users.length; i++) addUserToComboBox(users[i]);

function addUserToComboBox(user) {
  const u = document.createElement("option");
  u.value = user.username;
  u.text = u.value;
  foundUserCombobox.appendChild(u);
}

function addUser() {
  const uName = foundUserCombobox.value;

  if (uName == "0") {
    alert("You have to select a user!");
    return;
  } else if (uName == username) {
    alert("You can't choose yourself!");
    return;
  } else if (!selectedNote) {
    alert("You have to choose a note!");
    return;
  } else if (selectedNote.noteCreator != username) {
    alert("You can't add or remove user if you are not the creator!");
    return;
  }

  users.forEach((u) => {
    if (u.username != uName) return;

    var noteExist = false;
    u.notes.forEach((n) => {
      if (n.id == selectedNote.id) {
        noteExist = true;
        return;
      }
    });
    if (noteExist) {
      alert("This user already has this note!");
      return;
    }
    u.notes.push(selectedNote);
    alert("Note added to user!");
  });
}
document.querySelector("#addUser").addEventListener("click", addUser);

function removeUser() {
  const uName = foundUserCombobox.value;
  if (uName == "0") {
    alert("You have to select a user!");
    return;
  } else if (uName == username) {
    alert("You can't choose yourself!");
    return;
  } else if (!selectedNote) {
    alert("You have to choose a note!");
    return;
  } else if (selectedNote.noteCreator != username) {
    alert("You can't add or remove user if you are not the creator!");
    return;
  }

  var noteFound = false;
  users.forEach((u) => {
    if (u.username != uName) return;

    for (let i = 0; i < u.notes.length; i++) {
      const n = u.notes[i];
      if (n.id == selectedNote.id) {
        u.notes.splice(i, 1);
        noteFound = true;
        alert("Note removed from the user!");
        return;
      }
    }
  });
  if (!noteFound) alert("This user does not have this note!");
}
document.querySelector("#removeUser").addEventListener("click", removeUser);

function logout() {
  usernameInput.value = "";
  passwordInput.value = "";

  selectedNote = false;
  document.querySelector("#noteTitle").value = "";
  document.querySelector("#noteContent").value = "";
  document.querySelector(".header").children[1].classList.toggle("hidden");
  document.querySelector(".header").children[2].classList.toggle("hidden");
  document.querySelector(".showroom").classList.toggle("hidden");
  document.querySelector(".mainContent").classList.toggle("hidden");
  document.querySelector(".welcome").textContent = "";
  username = "";
  alert("Logged Out!");
}
document.querySelector("#logout").addEventListener("click", logout);
