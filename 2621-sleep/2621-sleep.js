/**
 * @param {number} millis
 * @return {Promise}
 */
async function sleep(millis) {
    let promises = new Promise(function (resolve){
        setTimeout (() => resolve() , millis);
    });
    await promises;
}

/** 
 * let t = Date.now()
 * sleep(100).then(() => console.log(Date.now() - t)) // 100
 */