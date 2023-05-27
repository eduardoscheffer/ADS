const getDolar = async () => {

    const rawJSON = await fetch('https://economia.awesomeapi.com.br/json/last/USD-BRL,EUR-BRL,BTC-BRL');

    const data = await rawJSON.json();

    console.log(`1 real hoje equivalem a $${Number(data.USDBRL.bid)}`);

    console.log(JSON.stringify(data, (key, value) => {
        return key, value;
    }, 4)); // retorna o JSON em string com todos os values e com identação de 4
}

getDolar()