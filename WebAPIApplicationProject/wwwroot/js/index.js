const PLANTFOOD_API_URL = "api/PlantFood";

let allPlantFoods = [];

async function getPlantFoods() {
    try {
        const response = await fetch(PLANTFOOD_API_URL);
        if (!response.ok) {
            throw new Error(`Erreur HTTP : ${response.status}`);
        }
        const plantFoods = await response.json();
        allPlantFoods = plantFoods;
        console.log(plantFoods);
        return plantFoods;
    } catch (error) {
        console.error('Erreur lors de la récupération des PlantFoods :', error);
        return [];
    }
}

function applyFilters() {
    const searchValue = document.getElementById('search').value.toLowerCase();
    const seasonChecked = document.getElementById('season-filter').checked;
    const vegetableChecked = document.getElementById('vegetable-filter').checked;
    const fruitChecked = document.getElementById('fruit-filter').checked;

    const filtered = allPlantFoods.filter(item => {
        const matchesSearch = item.name.toLowerCase().includes(searchValue);
        const matchesSeason = !seasonChecked || item.isSeasonal;
        const matchesVegetable = !vegetableChecked || item.isVegetable;
        const matchesFruit = !fruitChecked || !item.isVegetable;

        if (vegetableChecked && fruitChecked) {
            return matchesSearch && matchesSeason
        }
        else {
            return matchesSearch && matchesSeason && matchesVegetable && matchesFruit;
        }
    });

    displayPlantFoods(filtered);
}

function computeAccountSection() {
    const accountSection = document.getElementById('account-section')

    if (localStorage.getItem('token') && localStorage.getItem('username')) {
        accountSection.innerHTML = `
            <button onclick="logout()">Se déconnecter</button>
        `;
    }
    else {
        accountSection.innerHTML = `
            <button onclick="redirectTo('login')">Se connecter</button>
            <button onclick="redirectTo('signin')">Créer un compte</button>
        `;
    }
}

function displayPlantFoods(plantFoodList) {
    const listElement = document.getElementById('plant-food-list');
    listElement.innerHTML = "";

    plantFoodList.forEach(item => {
        const div = document.createElement('div');
        div.className = "card"
        const imageUrl = item.imageUrl || "";

        div.innerHTML = `
                    <img src="${imageUrl}" alt="${item.name}" />
                    <h2>${item.name}</h2>
                    <p>${item.isVegetable ? 'Légume' : 'Fruit'}</p>
                    <button>Voir plus</button>
                `;

        listElement.appendChild(div);
    });
}

function setupEventListeners() {
    document.getElementById('search').addEventListener('input', applyFilters);
    document.getElementById('season-filter').addEventListener('change', applyFilters);
    document.getElementById('vegetable-filter').addEventListener('change', applyFilters);
    document.getElementById('fruit-filter').addEventListener('change', applyFilters);
}

function redirectTo(value) { window.location.href = `${value}.html`; }

function logout() {
    localStorage.clear();
    window.location.href = 'index.html';
}

window.onload = async () => {
    await getPlantFoods();
    applyFilters();
    computeAccountSection();
    setupEventListeners();
};