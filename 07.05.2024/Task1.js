let ShoppingList = [
    { name: 'Butter', quantity: 20, bought: false },
    { name: 'Apples', quantity: 1, bought: false },
    { name: 'Chicken', quantity: 15, bought: true },
];

function Display(list) {
    let notBought = list.filter(item => !item.bought);
    let bought = list.filter(item => item.bought);

    console.log("Not bought products:");
    notBought.forEach(item => {
        console.log(`${item.name} - ${item.quantity}`);
    });

    console.log("\nBought products:");
    bought.forEach(item => {
        console.log(`${item.name} - ${item.quantity}`);
    });
}

function Add(list, Name, quantity) {
    let product = list.find(item => item.name === Name);

    if (product) {
        product.quantity += quantity;
    } else {
        list.push({ name: Name, quantity: quantity, bought: false });
    }
}

function Buy(list, Name) {
    let product = list.find(item => item.name === Name);

    if (product) {
        product.bought = true;
    } else {
        console.log(`Product ${Name} not found in the list.`);
    }
}

Display(ShoppingList);
Add(ShoppingList, 'Cheese', 1);
Add(ShoppingList, 'Apples', 1);
Buy(ShoppingList, 'Bread');
console.log("\nUpdated shopping list:");
Display(ShoppingList);
