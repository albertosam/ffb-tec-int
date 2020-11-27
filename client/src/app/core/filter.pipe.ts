import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
    name: 'filter'
})
export class FilterPipe implements PipeTransform {

    transform(items: any[], searchText: string, fieldName: string[]): any[] {

        // return empty array if array is falsy
        if (!items) { return []; }

        // return the original array if search text is empty
        if (!searchText) { return items; }

        // convert the searchText to lower case
        searchText = searchText.toLowerCase();

        // para facilitar a busca
        // contacatena o valor de todas as propriedades em uma única propriedade para que o texto buscado
        // seja verificado nesta
        items.map(a => fieldName.forEach(x => {
            a['allProperties'] = (a['allProperties'] || '') + ' ' + a[x];
            return a;
        }));

        // retrun the filtered array
        return items.filter(item => {

            if (item && item['allProperties']) {
                return item['allProperties'].toLowerCase().includes(searchText);
            }

            return false;
        });
    }
}